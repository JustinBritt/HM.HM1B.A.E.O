namespace HM.HM1B.A.E.O.Classes.Variables
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.Variables;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM1B.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedTimeBlocks;
    
    internal sealed class B : IB
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public B(
            VariableCollection<IsIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IsIndexElement> Value { get; }

        public int GetElementAt(
            IsIndexElement sIndexElement)
        {
            int value = 0;

            int rounded = (int)Math.Round(
                this.Value[sIndexElement].Value,
                0,
                MidpointRounding.AwayFromZero);

            if (this.Value[sIndexElement].Value.IsAlmost(rounded))
            {
                value = rounded;
            }

            return value;
        }

        public ImmutableList<KeyValuePair<Organization, int>> GetElementsAt(
            ImmutableList<IsIndexElement> sIndexElements)
        {
            return
                sIndexElements
                .Select(
                    i => KeyValuePair.Create<Organization, int>(
                        i.Value,
                        this.GetElementAt(i)))
                .ToImmutableList();
        }

        public Interfaces.Results.SurgeonNumberAssignedTimeBlocks.IB GetElementsAt(
            IBResultElementFactory BResultElementFactory,
            IBFactory BFactory,
            Is s)
        {
            RedBlackTree<IsIndexElement, IBResultElement> redBlackTree = new RedBlackTree<IsIndexElement, IBResultElement>();

            foreach (IsIndexElement sIndexElement in s.Value.Values)
            {
                redBlackTree.Add(
                    sIndexElement,
                    BResultElementFactory.Create(
                        sIndexElement,
                        this.GetElementAt(
                            sIndexElement)));
            }

            return BFactory.Create(
                redBlackTree);
        }
    }
}
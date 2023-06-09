namespace HM.HM1B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonStrategicTargetsVisitor<TKey, TValue> : ISurgeonStrategicTargetsVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonStrategicTargetsVisitor(
            INParameterElementFactory NParameterElementFactory,
            Is s)
        {
            this.NParameterElementFactory = NParameterElementFactory;

            this.s = s;

            this.RedBlackTree = new RedBlackTree<IsIndexElement, INParameterElement>();
        }

        private INParameterElementFactory NParameterElementFactory { get; }

        private Is s { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, INParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.Value[obj.Key];

            this.RedBlackTree.Add(
                sIndexElement,
                this.NParameterElementFactory.Create(
                    sIndexElement,
                    obj.Value));
        }
    }
}
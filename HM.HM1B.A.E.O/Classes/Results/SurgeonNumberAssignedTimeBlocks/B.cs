namespace HM.HM1B.A.E.O.Classes.Results.SurgeonNumberAssignedTimeBlocks
{
    using System.Collections.Immutable;
    using System.Linq;
 
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.Results.SurgeonNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class B : IB
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public B(
            ImmutableList<IBResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IBResultElement> Value { get; }

        public IBResultElement GetElementAt(
            IsIndexElement sIndexElement)
        {
            return this.Value
                .Where(w => w.sIndexElement == sIndexElement)
                .SingleOrDefault();
        }

        public int GetElementAtAsInt(
            IsIndexElement sIndexElement)
        {
            return this.Value
                .Where(w => w.sIndexElement == sIndexElement)
                .Select(w => w.Value)
                .SingleOrDefault();
        }

        public ImmutableList<IBResultElement> GetElementsAt(
            ImmutableList<IsIndexElement> sIndexElements)
        {
            return
                sIndexElements
                .Select(i => this.GetElementAt(i))
                .ToImmutableList();
        }

        public RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<Organization, INullableValue<int>> redBlackTree = new RedBlackTree<Organization, INullableValue<int>>(
                new HM.HM1B.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (IBResultElement BResultElement in this.Value)
            {
                redBlackTree.Add(
                    BResultElement.sIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        BResultElement.Value));
            }

            return redBlackTree;
        }
    }
}
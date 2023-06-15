namespace HM.HM1B.A.E.O.Classes.Results.SurgeonNumberAssignedTimeBlocks
{
    using System.Collections.Immutable;
    using System.Linq;
 
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.Results.SurgeonNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM1B.A.E.O.InterfacesVisitors.Results.SurgeonNumberAssignedTimeBlocks;

    internal sealed class B : IB
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public B(
            RedBlackTree<IsIndexElement, IBResultElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, IBResultElement> Value { get; }

        public IBResultElement GetElementAt(
            IsIndexElement sIndexElement)
        {
            return this.Value[sIndexElement];
        }

        public int GetElementAtAsInt(
            IsIndexElement sIndexElement)
        {
            return this.Value[sIndexElement].Value;
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
            IBVisitor<IsIndexElement, IBResultElement> yVisitor = new HM.HM1B.A.E.O.Visitors.Results.SurgeonNumberAssignedTimeBlocks.BVisitor<IsIndexElement, IBResultElement>(
                nullableValueFactory,
                new HM.HM1B.A.E.O.Classes.Comparers.OrganizationComparer());

            this.Value.AcceptVisitor(
                yVisitor);

            return yVisitor.RedBlackTree;
        }
    }
}
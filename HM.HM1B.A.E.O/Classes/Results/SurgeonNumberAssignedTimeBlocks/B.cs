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
    using HM.HM1B.A.E.O.InterfacesFactories.Comparers;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedTimeBlocks;
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
            IOrganizationComparerFactory organizationComparerFactory,
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IBVisitorFactory BVisitorFactory)
        {
            IBVisitor<IsIndexElement, IBResultElement> BVisitor = BVisitorFactory.Create<IsIndexElement, IBResultElement>(
                nullableValueFactory,
                redBlackTreeFactory,
                organizationComparerFactory.Create());

            this.Value.AcceptVisitor(
                BVisitor);

            return BVisitor.RedBlackTree;
        }
    }
}
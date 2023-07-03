namespace HM.HM1B.A.E.O.Classes.Results.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Comparers;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesVisitors.Results.SurgicalSpecialtyNumberAssignedTimeBlocks;

    internal sealed class B : IB
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public B(
            RedBlackTree<IΔParameterElement, IBResultElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IΔParameterElement, IBResultElement> Value { get; }

        public RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            IOrganizationComparerFactory organizationComparerFactory,
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IBVisitorFactory BVisitorFactory)
        {
            IBVisitor<IΔParameterElement, IBResultElement> BVisitor = BVisitorFactory.Create<IΔParameterElement, IBResultElement>(
                nullableValueFactory,
                redBlackTreeFactory,
                organizationComparerFactory.Create());

            this.Value.AcceptVisitor(
                BVisitor);

            return BVisitor.RedBlackTree;
        }
    }
}
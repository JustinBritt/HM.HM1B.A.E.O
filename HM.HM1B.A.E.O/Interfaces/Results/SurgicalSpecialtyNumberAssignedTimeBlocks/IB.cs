namespace HM.HM1B.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.InterfacesFactories.Comparers;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedTimeBlocks;

    public interface IB
    {
        RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            IOrganizationComparerFactory organizationComparerFactory,
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IBVisitorFactory BVisitorFactory);
    }
}
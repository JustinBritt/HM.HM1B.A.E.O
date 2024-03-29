﻿namespace HM.HM1B.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedTimeBlocks
{
    using HM.HM1B.A.E.O.Interfaces.Comparers;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM1B.A.E.O.InterfacesVisitors.Results.SurgeonNumberAssignedTimeBlocks;

    public interface IBVisitorFactory
    {
        IBVisitor<TKey, TValue> Create<TKey, TValue>(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IOrganizationComparer organizationComparer)
            where TKey : IsIndexElement
            where TValue : IBResultElement;
    }
}
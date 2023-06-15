namespace HM.HM1B.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IB
    {
        ImmutableList<IBResultElement> Value { get; }

        RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}
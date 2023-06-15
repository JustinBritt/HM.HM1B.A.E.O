namespace HM.HM1B.A.E.O.Interfaces.Results.SurgeonNumberAssignedTimeBlocks
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IB
    {
        ImmutableList<IBResultElement> Value { get; }

        IBResultElement GetElementAt(
            IsIndexElement sIndexElement);

        int GetElementAtAsInt(
            IsIndexElement sIndexElement);

        ImmutableList<IBResultElement> GetElementsAt(
            ImmutableList<IsIndexElement> sIndexElements);

        RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}
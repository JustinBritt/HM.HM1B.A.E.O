namespace HM.HM1B.A.E.O.InterfacesFactories.Indices
{
    using System.Collections.Immutable;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using Hl7.Fhir.Model;

    public interface ItFactory
    {
        It Create(
            RedBlackTree<FhirDateTime, ItIndexElement> value);
    }
}
namespace HM.HM1B.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;

    public interface It
    {
        ImmutableList<ItIndexElement> Value { get; }

        ItIndexElement GetElementAt(
            int value);

        ItIndexElement GetElementAt(
            FhirDateTime value);

        int GetT();
    }
}
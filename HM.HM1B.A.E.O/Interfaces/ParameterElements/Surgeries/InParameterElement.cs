namespace HM.HM1B.A.E.O.Interfaces.ParameterElements.Surgeries
{
    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;

    public interface InParameterElement
    {
        IsIndexElement sIndexElement { get; }

        IΛIndexElement ΛIndexElement { get; }

        INullableValue<int> Value { get; }
    }
}
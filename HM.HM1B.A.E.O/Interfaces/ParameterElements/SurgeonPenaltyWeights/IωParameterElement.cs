namespace HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonPenaltyWeights
{
    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;

    public interface IωParameterElement
    {
        IsIndexElement sIndexElement { get; }

        INullableValue<decimal> Value { get; }
    }
}
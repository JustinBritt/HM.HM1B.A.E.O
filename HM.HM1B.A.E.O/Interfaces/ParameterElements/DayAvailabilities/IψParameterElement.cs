namespace HM.HM1B.A.E.O.Interfaces.ParameterElements.DayAvailabilities
{
    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;

    public interface IψParameterElement
    {
        ItIndexElement tIndexElement { get; }

        INullableValue<bool> Value { get; }
    }
}
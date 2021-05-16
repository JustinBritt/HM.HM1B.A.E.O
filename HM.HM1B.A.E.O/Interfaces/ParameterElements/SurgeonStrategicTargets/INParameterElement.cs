namespace HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonStrategicTargets
{
    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;

    public interface INParameterElement
    {
        IsIndexElement sIndexElement { get; }

        PositiveInt Value { get; }
    }
}
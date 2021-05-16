namespace HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonServiceLevelTimeBlockRequirements
{
    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;

    public interface IAParameterElement
    {
        IsIndexElement sIndexElement { get; }

        Iυ1IndexElement υ1IndexElement { get; }

        PositiveInt Value { get; }
    }
}
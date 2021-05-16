namespace HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonStrategicTargets
{
    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonStrategicTargets;

    public interface INParameterElementFactory
    {
        INParameterElement Create(
            IsIndexElement sIndexElement,
            PositiveInt value);
    }
}
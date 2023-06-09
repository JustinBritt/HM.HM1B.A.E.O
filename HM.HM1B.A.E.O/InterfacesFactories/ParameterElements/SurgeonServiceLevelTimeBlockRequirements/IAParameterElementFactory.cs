namespace HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonServiceLevelTimeBlockRequirements
{
    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;

    public interface IAParameterElementFactory
    {
        IAParameterElement Create(
            IsIndexElement sIndexElement,
            Iυ1IndexElement υ1IndexElement,
            INullableValue<int> value);
    }
}
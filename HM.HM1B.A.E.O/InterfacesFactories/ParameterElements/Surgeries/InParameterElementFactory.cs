namespace HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.Surgeries
{
    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.Surgeries;

    public interface InParameterElementFactory
    {
        InParameterElement Create(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            INullableValue<int> value);
    }
}
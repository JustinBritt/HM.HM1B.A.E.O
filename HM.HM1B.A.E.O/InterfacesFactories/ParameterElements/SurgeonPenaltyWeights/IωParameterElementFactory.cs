namespace HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonPenaltyWeights
{
    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonPenaltyWeights;

    public interface IωParameterElementFactory
    {
        IωParameterElement Create(
            IsIndexElement sIndexElement,
            INullableValue<decimal> value);
    }
}
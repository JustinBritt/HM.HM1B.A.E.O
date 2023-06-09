namespace HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.DayAvailabilities
{
    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.DayAvailabilities;

    public interface IψParameterElementFactory
    {
        IψParameterElement Create(
            ItIndexElement tIndexElement,
            INullableValue<bool> value);
    }
}
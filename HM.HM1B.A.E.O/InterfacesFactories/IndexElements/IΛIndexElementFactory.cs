namespace HM.HM1B.A.E.O.InterfacesFactories.IndexElements
{
    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;

    public interface IΛIndexElementFactory
    {
        IΛIndexElement Create(
            INullableValue<int> value);
    }
}
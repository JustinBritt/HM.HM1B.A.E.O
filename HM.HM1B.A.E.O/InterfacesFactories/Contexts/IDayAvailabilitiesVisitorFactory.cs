namespace HM.HM1B.A.E.O.InterfacesFactories.Contexts
{
    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.DayAvailabilities;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;

    public interface IDayAvailabilitiesVisitorFactory
    {
        IDayAvailabilitiesVisitor<TKey, TValue> Create<TKey, TValue>(
            IψParameterElementFactory ψParameterElementFactory,
            It t)
            where TKey : FhirDateTime
            where TValue : INullableValue<bool>;
    }
}
namespace HM.HM1B.A.E.O.InterfacesFactories.Contexts
{
    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.Comparers;
    using HM.HM1B.A.E.O.InterfacesFactories.IndexElements;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;

    public interface IPlanningHorizonVisitorFactory
    {
        IPlanningHorizonVisitor<TKey, TValue> Create<TKey, TValue>(
            ItIndexElementFactory tIndexElementFactory,
            IFhirDateTimeComparer FhirDateTimeComparer)
            where TKey : INullableValue<int>
            where TValue : FhirDateTime;
    }
}
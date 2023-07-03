namespace HM.HM1B.A.E.O.InterfacesFactories.Contexts
{
    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.Surgeries;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;

    public interface ISurgeonScenarioMaximumNumberPatientsInnerVisitorFactory
    {
        ISurgeonScenarioMaximumNumberPatientsInnerVisitor<TKey, TValue> Create<TKey, TValue>(
            InParameterElementFactory nParameterElementFactory,
            IsIndexElement sIndexElement,
            IΛ Λ)
            where TKey : INullableValue<int>
            where TValue : INullableValue<int>;
    }
}
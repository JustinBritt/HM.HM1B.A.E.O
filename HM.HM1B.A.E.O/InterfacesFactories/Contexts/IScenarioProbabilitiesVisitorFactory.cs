namespace HM.HM1B.A.E.O.InterfacesFactories.Contexts
{
    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;

    public interface IScenarioProbabilitiesVisitorFactory
    {
        IScenarioProbabilitiesVisitor<TKey, TValue> Create<TKey, TValue>(
            IΡParameterElementFactory ΡParameterElementFactory,
            IΛ Λ)
            where TKey : INullableValue<int>
            where TValue : INullableValue<decimal>;
    }
}
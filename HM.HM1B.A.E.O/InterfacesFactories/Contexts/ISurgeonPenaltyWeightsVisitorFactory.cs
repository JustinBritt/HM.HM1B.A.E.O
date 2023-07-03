namespace HM.HM1B.A.E.O.InterfacesFactories.Contexts
{
    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;

    public interface ISurgeonPenaltyWeightsVisitorFactory
    {
        ISurgeonPenaltyWeightsVisitor<TKey, TValue> Create<TKey, TValue>(
            IωParameterElementFactory ωParameterElementFactory,
            Is s)
            where TKey : Organization
            where TValue : INullableValue<decimal>;
    }
}
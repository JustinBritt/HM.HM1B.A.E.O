namespace HM.HM1B.A.E.O.InterfacesFactories.Contexts
{
    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;

    public interface ISurgeonStrategicTargetsVisitorFactory
    {
        ISurgeonStrategicTargetsVisitor<TKey, TValue> Create<TKey, TValue>(
            INParameterElementFactory NParameterElementFactory,
            Is s)
            where TKey : Organization
            where TValue : INullableValue<int>;
    }
}
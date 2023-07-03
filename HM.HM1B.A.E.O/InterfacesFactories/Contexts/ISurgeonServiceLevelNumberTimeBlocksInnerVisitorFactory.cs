namespace HM.HM1B.A.E.O.InterfacesFactories.Contexts
{
    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;

    public interface ISurgeonServiceLevelNumberTimeBlocksInnerVisitorFactory
    {
        ISurgeonServiceLevelNumberTimeBlocksInnerVisitor<TKey, TValue> Create<TKey, TValue>(
            IAParameterElementFactory AParameterElementFactory,
            IsIndexElement sIndexElement,
            Iυ1 υ1)
            where TKey : INullableValue<int>
            where TValue : INullableValue<int>;
    }
}
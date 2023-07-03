namespace HM.HM1B.A.E.O.InterfacesFactories.Contexts
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;

    public interface ISurgeonServiceLevelNumberTimeBlocksOuterVisitorFactory
    {
        ISurgeonServiceLevelNumberTimeBlocksOuterVisitor<TKey, TValue> Create<TKey, TValue>(
            ISurgeonServiceLevelNumberTimeBlocksInnerVisitorFactory surgeonServiceLevelNumberTimeBlocksInnerVisitorFactory,
            IAParameterElementFactory AParameterElementFactory,
            Is s,
            Iυ1 υ1)
            where TKey : Organization
            where TValue : RedBlackTree<INullableValue<int>, INullableValue<int>>;
    }
}
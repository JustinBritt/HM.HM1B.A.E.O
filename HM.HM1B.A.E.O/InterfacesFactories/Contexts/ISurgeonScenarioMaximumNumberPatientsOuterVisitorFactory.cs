namespace HM.HM1B.A.E.O.InterfacesFactories.Contexts
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.Surgeries;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;

    public interface ISurgeonScenarioMaximumNumberPatientsOuterVisitorFactory
    {
        ISurgeonScenarioMaximumNumberPatientsOuterVisitor<TKey, TValue> Create<TKey, TValue>(
            InParameterElementFactory nParameterElementFactory,
            Is s,
            IΛ Λ)
            where TKey : Organization
            where TValue : RedBlackTree<INullableValue<int>, INullableValue<int>>;
    }
}
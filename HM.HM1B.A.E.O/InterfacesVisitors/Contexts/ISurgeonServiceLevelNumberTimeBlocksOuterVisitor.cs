namespace HM.HM1B.A.E.O.InterfacesVisitors.Contexts
{
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;

    public interface ISurgeonServiceLevelNumberTimeBlocksOuterVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : Organization
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<int>>
    {
        RedBlackTree<IsIndexElement, RedBlackTree<Iυ1IndexElement, IAParameterElement>> RedBlackTree { get; }
    }
}
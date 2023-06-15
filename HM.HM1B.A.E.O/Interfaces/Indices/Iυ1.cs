namespace HM.HM1B.A.E.O.Interfaces.Indices
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;

    public interface Iυ1
    {
        RedBlackTree<INullableValue<int>, Iυ1IndexElement> Value { get; }

        Iυ1IndexElement GetElementAt(
            INullableValue<int> value);
    }
}
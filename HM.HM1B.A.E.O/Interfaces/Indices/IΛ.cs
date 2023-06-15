namespace HM.HM1B.A.E.O.Interfaces.Indices
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
   
    public interface IΛ
    {
        RedBlackTree<INullableValue<int>, IΛIndexElement> Value { get; }

        IΛIndexElement GetElementAt(
            INullableValue<int> value);
    }
}
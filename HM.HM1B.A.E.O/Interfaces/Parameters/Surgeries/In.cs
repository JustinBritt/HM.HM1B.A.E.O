namespace HM.HM1B.A.E.O.Interfaces.Parameters.Surgeries
{
    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.Surgeries;

    public interface In
    {
        RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, InParameterElement>> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement);
    }
}
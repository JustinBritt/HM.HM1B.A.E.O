namespace HM.HM1B.A.E.O.InterfacesFactories.Parameters.Surgeries
{
    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.Surgeries;
    using HM.HM1B.A.E.O.Interfaces.Parameters.Surgeries;

    public interface InFactory
    {
        In Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, InParameterElement>> value);
    }
}
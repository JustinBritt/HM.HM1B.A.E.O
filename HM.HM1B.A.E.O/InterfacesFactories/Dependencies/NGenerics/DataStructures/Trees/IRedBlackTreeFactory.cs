namespace HM.HM1B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees
{
    using global::NGenerics.DataStructures.Trees;

    public interface IRedBlackTreeFactory
    {
        RedBlackTree<TKey, TValue> Create<TKey, TValue>();
    }
}
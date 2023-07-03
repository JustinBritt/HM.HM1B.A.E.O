namespace HM.HM1B.A.E.O.Factories.Dependencies.NGenerics.DataStructures.Trees
{
    using System;

    using log4net;

    using global::NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;

    internal sealed class RedBlackTreeFactory : IRedBlackTreeFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RedBlackTreeFactory()
        {
        }

        public RedBlackTree<TKey, TValue> Create<TKey, TValue>()
        {
            RedBlackTree<TKey, TValue> model = null;

            try
            {
                model = new RedBlackTree<TKey, TValue>();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return model;
        }
    }
}
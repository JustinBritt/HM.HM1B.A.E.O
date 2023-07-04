namespace HM.HM1B.A.E.O.Factories.Indices
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Classes.Indices;
    using HM.HM1B.A.E.O.Interfaces.Comparers;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM1B.A.E.O.InterfacesFactories.Indices;
    
    internal sealed class ΛFactory : IΛFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΛFactory()
        {
        }

        public IΛ Create(
            IRedBlackTreeFactory redBlackTreeFactory,
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IΛIndexElement> value)
        {
            IΛ index = null;

            try
            {
                index = new Λ(
                    this.CreateRedBlackTree(
                        redBlackTreeFactory,
                        nullableValueintComparer,
                        value));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return index;
        }

        private RedBlackTree<INullableValue<int>, IΛIndexElement> CreateRedBlackTree(
            IRedBlackTreeFactory redBlackTreeFactory,
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IΛIndexElement> value)
        {
            RedBlackTree<INullableValue<int>, IΛIndexElement> redBlackTree = redBlackTreeFactory.Create<INullableValue<int>, IΛIndexElement>(
                nullableValueintComparer);

            foreach (IΛIndexElement ΛIndexElement in value)
            {
                redBlackTree.Add(
                    ΛIndexElement.Value,
                    ΛIndexElement);
            }

            return redBlackTree;
        }
    }
}
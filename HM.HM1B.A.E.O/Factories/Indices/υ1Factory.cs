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
    
    internal sealed class υ1Factory : Iυ1Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public υ1Factory()
        {
        }

        public Iυ1 Create(
            IRedBlackTreeFactory redBlackTreeFactory,
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<Iυ1IndexElement> value)
        {
            Iυ1 index = null;

            try
            {
                index = new υ1(
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

        private RedBlackTree<INullableValue<int>, Iυ1IndexElement> CreateRedBlackTree(
            IRedBlackTreeFactory redBlackTreeFactory,
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<Iυ1IndexElement> value)
        {
            RedBlackTree<INullableValue<int>, Iυ1IndexElement> redBlackTree = redBlackTreeFactory.Create<INullableValue<int>, Iυ1IndexElement>(
                nullableValueintComparer);

            foreach (Iυ1IndexElement υ1IndexElement in value)
            {
                redBlackTree.Add(
                    υ1IndexElement.Value,
                    υ1IndexElement);
            }

            return redBlackTree;
        }
    }
}
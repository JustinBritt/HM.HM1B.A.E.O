namespace HM.HM1B.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.Contexts;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;
    using HM.HM1B.A.E.O.Visitors.Contexts;

    internal sealed class SurgeonServiceLevelNumberTimeBlocksOuterVisitorFactory : ISurgeonServiceLevelNumberTimeBlocksOuterVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonServiceLevelNumberTimeBlocksOuterVisitorFactory()
        {
        }

        public ISurgeonServiceLevelNumberTimeBlocksOuterVisitor<TKey, TValue> Create<TKey, TValue>(
            ISurgeonServiceLevelNumberTimeBlocksInnerVisitorFactory surgeonServiceLevelNumberTimeBlocksInnerVisitorFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IAParameterElementFactory AParameterElementFactory,
            Is s,
            Iυ1 υ1)
            where TKey : Organization
            where TValue : RedBlackTree<INullableValue<int>, INullableValue<int>>
        {
            ISurgeonServiceLevelNumberTimeBlocksOuterVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new SurgeonServiceLevelNumberTimeBlocksOuterVisitor<TKey, TValue>(
                    surgeonServiceLevelNumberTimeBlocksInnerVisitorFactory,
                    redBlackTreeFactory,
                    AParameterElementFactory,
                    s,
                    υ1);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}
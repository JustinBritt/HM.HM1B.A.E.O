namespace HM.HM1B.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.Contexts;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;
    using HM.HM1B.A.E.O.Visitors.Contexts;

    internal sealed class SurgeonServiceLevelNumberTimeBlocksInnerVisitorFactory : ISurgeonServiceLevelNumberTimeBlocksInnerVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonServiceLevelNumberTimeBlocksInnerVisitorFactory()
        {
        }

        public ISurgeonServiceLevelNumberTimeBlocksInnerVisitor<TKey, TValue> Create<TKey, TValue>(
            IRedBlackTreeFactory redBlackTreeFactory,
            IAParameterElementFactory AParameterElementFactory,
            IsIndexElement sIndexElement,
            Iυ1 υ1)
            where TKey : INullableValue<int>
            where TValue : INullableValue<int>
        {
            ISurgeonServiceLevelNumberTimeBlocksInnerVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new SurgeonServiceLevelNumberTimeBlocksInnerVisitor<TKey, TValue>(
                    redBlackTreeFactory,
                    AParameterElementFactory,
                    sIndexElement,
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
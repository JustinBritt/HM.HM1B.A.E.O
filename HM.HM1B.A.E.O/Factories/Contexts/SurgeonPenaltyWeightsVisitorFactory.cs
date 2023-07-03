namespace HM.HM1B.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.Contexts;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;
    using HM.HM1B.A.E.O.Visitors.Contexts;

    internal sealed class SurgeonPenaltyWeightsVisitorFactory : ISurgeonPenaltyWeightsVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonPenaltyWeightsVisitorFactory()
        {
        }

        public ISurgeonPenaltyWeightsVisitor<TKey, TValue> Create<TKey, TValue>(
            IωParameterElementFactory ωParameterElementFactory,
            Is s)
            where TKey : Organization
            where TValue : INullableValue<decimal>
        {
            ISurgeonPenaltyWeightsVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new SurgeonPenaltyWeightsVisitor<TKey, TValue>(
                    ωParameterElementFactory,
                    s);
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
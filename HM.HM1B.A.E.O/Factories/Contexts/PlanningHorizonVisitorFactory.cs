namespace HM.HM1B.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.Comparers;
    using HM.HM1B.A.E.O.InterfacesFactories.Contexts;
    using HM.HM1B.A.E.O.InterfacesFactories.IndexElements;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;
    using HM.HM1B.A.E.O.Visitors.Contexts;

    internal sealed class PlanningHorizonVisitorFactory<TKey, TValue> : IPlanningHorizonVisitorFactory<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : FhirDateTime
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PlanningHorizonVisitorFactory()
        {
        }

        public IPlanningHorizonVisitor<TKey, TValue> Create(
            ItIndexElementFactory tIndexElementFactory,
            IFhirDateTimeComparer FhirDateTimeComparer)
        {
            IPlanningHorizonVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new PlanningHorizonVisitor<TKey, TValue>(
                    tIndexElementFactory,
                    FhirDateTimeComparer);
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
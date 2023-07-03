namespace HM.HM1B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Factories.Contexts;
    using HM.HM1B.A.E.O.InterfacesAbstractFactories;
    using HM.HM1B.A.E.O.InterfacesFactories.Contexts;
    
    internal sealed class ContextsAbstractFactory : IContextsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ContextsAbstractFactory()
        {
        }

        public IDayAvailabilitiesVisitorFactory CreateDayAvailabilitiesVisitorFactory()
        {
            IDayAvailabilitiesVisitorFactory factory = null;

            try
            {
                factory = new DayAvailabilitiesVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IHM1BInputContextFactory CreateHM1BInputContextFactory()
        {
            IHM1BInputContextFactory factory = null;

            try
            {
                factory = new HM1BInputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IHM1BOutputContextFactory CreateHM1BOutputContextFactory()
        {
            IHM1BOutputContextFactory factory = null;

            try
            {
                factory = new HM1BOutputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IPlanningHorizonVisitorFactory CreatePlanningHorizonVisitorFactory()
        {
            IPlanningHorizonVisitorFactory factory = null;

            try
            {
                factory = new PlanningHorizonVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}
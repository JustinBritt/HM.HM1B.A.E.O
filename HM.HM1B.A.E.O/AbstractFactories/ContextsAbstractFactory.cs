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

        public IScenarioProbabilitiesVisitorFactory CreateScenarioProbabilitiesVisitorFactory()
        {
            IScenarioProbabilitiesVisitorFactory factory = null;

            try
            {
                factory = new ScenarioProbabilitiesVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonPenaltyWeightsVisitorFactory CreateSurgeonPenaltyWeightsVisitorFactory()
        {
            ISurgeonPenaltyWeightsVisitorFactory factory = null;

            try
            {
                factory = new SurgeonPenaltyWeightsVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonScenarioMaximumNumberPatientsOuterVisitorFactory CreateSurgeonScenarioMaximumNumberPatientsOuterVisitorFactory()
        {
            ISurgeonScenarioMaximumNumberPatientsOuterVisitorFactory factory = null;

            try
            {
                factory = new SurgeonScenarioMaximumNumberPatientsOuterVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonServiceLevelNumberTimeBlocksOuterVisitorFactory CreateSurgeonServiceLevelNumberTimeBlocksOuterVisitorFactory()
        {
            ISurgeonServiceLevelNumberTimeBlocksOuterVisitorFactory factory = null;

            try
            {
                factory = new SurgeonServiceLevelNumberTimeBlocksOuterVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonStrategicTargetsVisitorFactory CreateSurgeonStrategicTargetsVisitorFactory()
        {
            ISurgeonStrategicTargetsVisitorFactory factory = null;

            try
            {
                factory = new SurgeonStrategicTargetsVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgicalSpecialtiesVisitorFactory CreateSurgicalSpecialtiesVisitorFactory()
        {
            ISurgicalSpecialtiesVisitorFactory factory = null;

            try
            {
                factory = new SurgicalSpecialtiesVisitorFactory();
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
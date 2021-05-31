namespace HM.HM1B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Factories.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesAbstractFactories;
    using HM.HM1B.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks;

    internal sealed class CalculationsAbstractFactory : ICalculationsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CalculationsAbstractFactory()
        {
        }

        public IBCalculationFactory CreateBCalculationFactory()
        {
            IBCalculationFactory factory = null;

            try
            {
                factory = new BCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBResultElementCalculationFactory CreateBResultElementCalculationFactory()
        {
            IBResultElementCalculationFactory factory = null;

            try
            {
                factory = new BResultElementCalculationFactory();
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
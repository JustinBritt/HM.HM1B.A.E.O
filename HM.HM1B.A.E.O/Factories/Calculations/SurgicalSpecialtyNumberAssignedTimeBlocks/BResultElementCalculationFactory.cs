namespace HM.HM1B.A.E.O.Factories.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Classes.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks;

    internal sealed class BResultElementCalculationFactory : IBResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BResultElementCalculationFactory()
        {
        }

        public IBResultElementCalculation Create()
        {
            IBResultElementCalculation calculation = null;

            try
            {
                calculation = new BResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}
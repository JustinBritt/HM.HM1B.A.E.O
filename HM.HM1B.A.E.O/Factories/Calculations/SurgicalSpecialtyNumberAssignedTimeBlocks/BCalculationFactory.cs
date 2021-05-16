namespace HM.HM1B.A.E.O.Factories.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Classes.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks;

    internal sealed class BCalculationFactory : IBCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BCalculationFactory()
        {
        }

        public IBCalculation Create()
        {
            IBCalculation calculation = null;

            try
            {
                calculation = new BCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}
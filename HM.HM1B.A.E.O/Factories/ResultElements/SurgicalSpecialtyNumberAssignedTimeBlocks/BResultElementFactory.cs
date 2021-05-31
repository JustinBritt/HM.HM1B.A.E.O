namespace HM.HM1B.A.E.O.Factories.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Classes.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;

    internal sealed class BResultElementFactory : IBResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BResultElementFactory()
        {
        }

        public IBResultElement Create(
            IjIndexElement jIndexElement,
            int value)
        {
            IBResultElement resultElement = null;

            try
            {
                resultElement = new BResultElement(
                    jIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return resultElement;
        }
    }
}
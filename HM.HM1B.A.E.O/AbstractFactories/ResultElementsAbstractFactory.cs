namespace HM.HM1B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.InterfacesAbstractFactories;

    internal sealed class ResultElementsAbstractFactory : IResultElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResultElementsAbstractFactory()
        {
        }

        public HM.HM1B.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks.IBResultElementFactory CreateBBarResultElementFactory()
        {
            HM.HM1B.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks.IBResultElementFactory factory = null;

            try
            {
                factory = new HM.HM1B.A.E.O.Factories.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks.BResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public HM.HM1B.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedTimeBlocks.IBResultElementFactory CreateBsResultElementFactory()
        {
            HM.HM1B.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedTimeBlocks.IBResultElementFactory factory = null;

            try
            {
                factory = new HM.HM1B.A.E.O.Factories.ResultElements.SurgeonNumberAssignedTimeBlocks.BResultElementFactory();
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
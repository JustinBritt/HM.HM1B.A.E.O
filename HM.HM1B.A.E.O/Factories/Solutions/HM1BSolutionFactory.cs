namespace HM.HM1B.A.E.O.Factories.Solutions
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Classes.Solutions;
    using HM.HM1B.A.E.O.Interfaces.Solutions;
    using HM.HM1B.A.E.O.InterfacesFactories.Solutions;

    internal sealed class HM1BSolutionFactory : IHM1BSolutionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM1BSolutionFactory()
        {
        }

        public IHM1BSolution Create()
        {
            IHM1BSolution solution = null;

            try
            {
                solution = new HM1BSolution();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return solution;
        }
    }
}
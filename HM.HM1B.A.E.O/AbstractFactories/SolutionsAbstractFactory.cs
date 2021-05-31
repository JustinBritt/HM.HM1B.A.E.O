namespace HM.HM1B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Factories.Solutions;
    using HM.HM1B.A.E.O.InterfacesAbstractFactories;
    using HM.HM1B.A.E.O.InterfacesFactories.Solutions;

    internal sealed class SolutionsAbstractFactory : ISolutionsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SolutionsAbstractFactory()
        {
        }

        public IHM1BSolutionFactory CreateHM1BSolutionFactory()
        {
            IHM1BSolutionFactory factory = null;

            try
            {
                factory = new HM1BSolutionFactory();
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
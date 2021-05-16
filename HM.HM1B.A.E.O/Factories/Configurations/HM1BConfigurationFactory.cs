namespace HM.HM1B.A.E.O.Factories.Configurations
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using HM.HM1B.A.E.O.Classes.Configurations;
    using HM.HM1B.A.E.O.Interfaces.Configurations;
    using HM.HM1B.A.E.O.InterfacesFactories.Configurations;

    internal sealed class HM1BConfigurationFactory : IHM1BConfigurationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM1BConfigurationFactory()
        {
        }

        public IHM1BConfiguration Create(
            Configuration configuration)
        {
            IHM1BConfiguration HM1BConfiguration = null;

            try
            {
                HM1BConfiguration = new HM1BConfiguration(
                    configuration);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return HM1BConfiguration;
        }
    }
}
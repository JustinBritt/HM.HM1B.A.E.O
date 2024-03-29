﻿namespace HM.HM1B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Factories.Configurations;
    using HM.HM1B.A.E.O.InterfacesAbstractFactories;
    using HM.HM1B.A.E.O.InterfacesFactories.Configurations;

    internal sealed class ConfigurationsAbstractFactory : IConfigurationsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConfigurationsAbstractFactory()
        {
        }

        public IHM1BConfigurationFactory CreateHM1BConfigurationFactory()
        {
            IHM1BConfigurationFactory factory = null;

            try
            {
                factory = new HM1BConfigurationFactory();
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
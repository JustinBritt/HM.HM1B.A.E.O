namespace HM.HM1B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Factories.ObjectiveFunctions;
    using HM.HM1B.A.E.O.InterfacesAbstractFactories;
    using HM.HM1B.A.E.O.InterfacesFactories.ObjectiveFunctions;

    internal sealed class ObjectiveFunctionsAbstractFactory : IObjectiveFunctionsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFunctionsAbstractFactory()
        {
        }

        public IObjectiveFunction100Factory CreateObjectiveFunction100Factory()
        {
            IObjectiveFunction100Factory factory = null;

            try
            {
                factory = new ObjectiveFunction100Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IObjectiveFunction110Factory CreateObjectiveFunction110Factory()
        {
            IObjectiveFunction110Factory factory = null;

            try
            {
                factory = new ObjectiveFunction110Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IObjectiveFunction111Factory CreateObjectiveFunction111Factory()
        {
            IObjectiveFunction111Factory factory = null;

            try
            {
                factory = new ObjectiveFunction111Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}
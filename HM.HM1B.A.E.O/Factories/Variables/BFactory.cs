namespace HM.HM1B.A.E.O.Factories.Variables
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM1B.A.E.O.Classes.Variables;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Variables;
    using HM.HM1B.A.E.O.InterfacesFactories.Variables;

    internal sealed class BFactory : IBFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BFactory()
        {
        }

        public IB Create(
            VariableCollection<IsIndexElement> value)
        {
            IB variable = null;

            try
            {
                variable = new B(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variable;
        }
    }
}
namespace HM.HM1B.A.E.O.Factories.Variables
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM1B.A.E.O.Classes.Variables;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Variables;
    using HM.HM1B.A.E.O.InterfacesFactories.Variables;

    internal sealed class e1MinusFactory : Ie1MinusFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public e1MinusFactory()
        {
        }

        public Ie1Minus Create(
            VariableCollection<IsIndexElement, IΛIndexElement> value)
        {
            Ie1Minus variable = null;

            try
            {
                variable = new e1Minus(
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
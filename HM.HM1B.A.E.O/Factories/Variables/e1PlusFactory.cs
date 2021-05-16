namespace HM.HM1B.A.E.O.Factories.Variables
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM1B.A.E.O.Classes.Variables;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Variables;
    using HM.HM1B.A.E.O.InterfacesFactories.Variables;

    internal sealed class e1PlusFactory : Ie1PlusFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public e1PlusFactory()
        {
        }

        public Ie1Plus Create(
            VariableCollection<IsIndexElement, IΛIndexElement> value)
        {
            Ie1Plus variable = null;

            try
            {
                variable = new e1Plus(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return variable;
        }
    }
}
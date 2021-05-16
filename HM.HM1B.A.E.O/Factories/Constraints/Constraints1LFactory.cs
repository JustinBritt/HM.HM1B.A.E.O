namespace HM.HM1B.A.E.O.Factories.Constraints
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM1B.A.E.O.Classes.Constraints;
    using HM.HM1B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM1B.A.E.O.Interfaces.Constraints;
    using HM.HM1B.A.E.O.InterfacesFactories.Constraints;

    internal sealed class Constraints1LFactory : IConstraints1LFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1LFactory()
        {
        }

        public IConstraints1L Create(
            ImmutableList<IConstraints1LConstraintElement> value)
        {
            IConstraints1L constraint = null;

            try
            {
                constraint = new Constraints1L(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraint;
        }
    }
}
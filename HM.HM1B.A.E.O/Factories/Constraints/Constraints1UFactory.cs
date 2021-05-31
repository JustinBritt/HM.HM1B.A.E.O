namespace HM.HM1B.A.E.O.Factories.Constraints
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM1B.A.E.O.Classes.Constraints;
    using HM.HM1B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM1B.A.E.O.Interfaces.Constraints;
    using HM.HM1B.A.E.O.InterfacesFactories.Constraints;

    internal sealed class Constraints1UFactory : IConstraints1UFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1UFactory()
        {
        }

        public IConstraints1U Create(
            ImmutableList<IConstraints1UConstraintElement> value)
        {
            IConstraints1U constraint = null;

            try
            {
                constraint = new Constraints1U(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraint;
        }
    }
}
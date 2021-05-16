namespace HM.HM1B.A.E.O.Factories.Constraints
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Classes.Constraints;
    using HM.HM1B.A.E.O.Interfaces.Constraints;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.Interfaces.Parameters.DayAvailabilities;
    using HM.HM1B.A.E.O.Interfaces.Variables;
    using HM.HM1B.A.E.O.InterfacesFactories.Constraints;

    internal sealed class Constraint2Factory : IConstraint2Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraint2Factory()
        {
        }

        public IConstraint2 Create(
            Ir r,
            Is s,
            It t,
            Iψ ψ,
            IB B)
        {
            IConstraint2 constraint = null;

            try
            {
                constraint = new Constraint2(
                    r,
                    s,
                    t,
                    ψ,
                    B);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraint;
        }
    }
}
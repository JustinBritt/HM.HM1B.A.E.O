namespace HM.HM1B.A.E.O.Classes.Constraints
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM1B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM1B.A.E.O.Interfaces.Constraints;

    internal sealed class Constraints1U : IConstraints1U
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1U(
            ImmutableList<IConstraints1UConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints1UConstraintElement> Value { get; }
    }
}
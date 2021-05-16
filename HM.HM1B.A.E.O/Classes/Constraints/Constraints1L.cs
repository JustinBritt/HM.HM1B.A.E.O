namespace HM.HM1B.A.E.O.Classes.Constraints
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM1B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM1B.A.E.O.Interfaces.Constraints;

    internal sealed class Constraints1L : IConstraints1L
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1L(
            ImmutableList<IConstraints1LConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints1LConstraintElement> Value { get; }
    }
}
namespace HM.HM1B.A.E.O.Classes.Constraints
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM1B.A.E.O.Interfaces.Constraints;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.Interfaces.Parameters.DayAvailabilities;
    using HM.HM1B.A.E.O.Interfaces.Variables;

    internal sealed class Constraint2 : IConstraint2
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraint2(
            Ir r,
            Is s,
            It t,
            Iψ ψ,
            IB B)
        {
            Expression LHS = Expression.Sum(
                s.Value.Values
                .Select(x => B.Value[x]));

            int RHS = r.GetR()
                *
                t.Value.Values
                .Select(x => 1 - ψ.GetElementAtAsint(x))
                .Sum();

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}
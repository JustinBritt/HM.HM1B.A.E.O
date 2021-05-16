namespace HM.HM1B.A.E.O.Classes.ConstraintElements
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM1B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.Interfaces.Variables;

    internal sealed class Constraints1UConstraintElement : IConstraints1UConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1UConstraintElement(
            IsIndexElement sIndexElement,
            Iυ1IndexElement υ1StarPlus1,
            IA A,
            IB B)
        {
            Expression LHS = B.Value[sIndexElement];

            int RHS = A.GetElementAtAsint(
                sIndexElement,
                υ1StarPlus1);

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}
namespace HM.HM1B.A.E.O.Classes.ConstraintElements
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM1B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.Interfaces.Variables;

    internal sealed class Constraints1LConstraintElement : IConstraints1LConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1LConstraintElement(
            IsIndexElement sIndexElement,
            Iυ1IndexElement υ1Star,
            IA A,
            IB B)
        {
            int LHS = A.GetElementAtAsint(
                sIndexElement,
                υ1Star);

            Expression RHS = B.Value[sIndexElement];

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}
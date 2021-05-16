namespace HM.HM1B.A.E.O.Classes.ConstraintElements
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM1B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.Interfaces.Parameters.Surgeries;
    using HM.HM1B.A.E.O.Interfaces.Variables;

    internal sealed class Constraints3ConstraintElement : IConstraints3ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints3ConstraintElement(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            IN N,
            In n,
            IB B,
            Ie1Minus e1Minus,
            Ie1Plus e1Plus)
        {
            Expression LHS = n.GetElementAtAsint(
                sIndexElement,
                ΛIndexElement)
                *
                B.Value[sIndexElement]
                +
                e1Minus.Value[sIndexElement, ΛIndexElement]
                -
                e1Plus.Value[sIndexElement, ΛIndexElement];

            int RHS = N.GetElementAtAsint(
                sIndexElement);

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}
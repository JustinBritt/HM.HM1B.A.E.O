namespace HM.HM1B.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Classes.ConstraintElements;
    using HM.HM1B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.Interfaces.Parameters.Surgeries;
    using HM.HM1B.A.E.O.Interfaces.Variables;
    using HM.HM1B.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints3ConstraintElementFactory : IConstraints3ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints3ConstraintElementFactory()
        {
        }

        public IConstraints3ConstraintElement Create(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            IN N,
            In n,
            IB B,
            Ie1Minus e1Minus,
            Ie1Plus e1Plus)
        {
            IConstraints3ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints3ConstraintElement(
                    sIndexElement,
                    ΛIndexElement,
                    N,
                    n,
                    B,
                    e1Minus,
                    e1Plus);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraintElement;
        }
    }
}
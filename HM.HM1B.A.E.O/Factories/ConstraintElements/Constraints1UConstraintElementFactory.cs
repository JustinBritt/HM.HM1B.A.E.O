namespace HM.HM1B.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Classes.ConstraintElements;
    using HM.HM1B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.Interfaces.Variables;
    using HM.HM1B.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints1UConstraintElementFactory : IConstraints1UConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1UConstraintElementFactory()
        {
        }

        public IConstraints1UConstraintElement Create(
            IsIndexElement sIndexElement,
            Iυ1IndexElement υ1StarPlus1,
            IA A,
            IB B)
        {
            IConstraints1UConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints1UConstraintElement(
                    sIndexElement,
                    υ1StarPlus1,
                    A,
                    B);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraintElement;
        }
    }
}
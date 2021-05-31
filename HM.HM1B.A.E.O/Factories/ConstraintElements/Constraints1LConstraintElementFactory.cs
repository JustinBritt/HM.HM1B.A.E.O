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

    internal sealed class Constraints1LConstraintElementFactory : IConstraints1LConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1LConstraintElementFactory()
        {
        }

        public IConstraints1LConstraintElement Create(
            IsIndexElement sIndexElement,
            Iυ1IndexElement υ1Star,
            IA A,
            IB B)
        {
            IConstraints1LConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints1LConstraintElement(
                    sIndexElement,
                    υ1Star,
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
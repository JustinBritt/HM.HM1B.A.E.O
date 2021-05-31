namespace HM.HM1B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Factories.ConstraintElements;
    using HM.HM1B.A.E.O.InterfacesAbstractFactories;
    using HM.HM1B.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class ConstraintElementsAbstractFactory : IConstraintElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConstraintElementsAbstractFactory()
        {
        }

        public IConstraints1LConstraintElementFactory CreateConstraints1LConstraintElementFactory()
        {
            IConstraints1LConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints1LConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints1UConstraintElementFactory CreateConstraints1UConstraintElementFactory()
        {
            IConstraints1UConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints1UConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints3ConstraintElementFactory CreateConstraints3ConstraintElementFactory()
        {
            IConstraints3ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints3ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}
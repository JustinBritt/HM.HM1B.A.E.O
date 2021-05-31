namespace HM.HM1B.A.E.O.Factories.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Classes.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.InterfacesFactories.IndexElements;

    internal sealed class υ1IndexElementFactory : Iυ1IndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public υ1IndexElementFactory()
        {
        }

        public Iυ1IndexElement Create(
            PositiveInt value)
        {
            Iυ1IndexElement indexElement = null;

            try
            {
                indexElement = new υ1IndexElement(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return indexElement;
        }
    }
}
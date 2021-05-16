namespace HM.HM1B.A.E.O.Factories.Parameters.ServiceLevelAssignments
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Classes.Parameters.ServiceLevelAssignments;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Parameters.ServiceLevelAssignments;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.ServiceLevelAssignments;

    internal sealed class υ1StarFactory : Iυ1StarFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public υ1StarFactory()
        {
        }

        public Iυ1Star Create(
            Iυ1IndexElement value)
        {
            Iυ1Star parameter = null;

            try
            {
                parameter = new υ1Star(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameter;
        }
    }
}
namespace HM.HM1B.A.E.O.Classes.Parameters.ServiceLevelAssignments
{
    using log4net;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Parameters.ServiceLevelAssignments;

    internal sealed class υ1Star : Iυ1Star
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public υ1Star(
            Iυ1IndexElement value)
        {
            this.Value = value;
        }

        public Iυ1IndexElement Value { get; }
    }
}
namespace HM.HM1B.A.E.O.Classes.Parameters.ServiceLevelAssignments
{
    using log4net;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Parameters.ServiceLevelAssignments;

    internal sealed class υ1StarPlus1 : Iυ1StarPlus1
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public υ1StarPlus1(
            Iυ1IndexElement value)
        {
            this.Value = value;
        }

        public Iυ1IndexElement Value { get; }
    }
}
namespace HM.HM1B.A.E.O.Classes.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using log4net;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;

    internal sealed class BResultElement : IBResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BResultElement(
            IjIndexElement jIndexElement,
            int value)
        {
            this.jIndexElement = jIndexElement;

            this.Value = value;
        }

        public IjIndexElement jIndexElement { get; }

        public int Value { get; }
    }
}
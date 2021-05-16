namespace HM.HM1B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using HM.HM1B.A.E.O.Interfaces.IndexElements;

    public interface IBResultElement
    {
        IjIndexElement jIndexElement { get; }

        int Value { get; }
    }
}
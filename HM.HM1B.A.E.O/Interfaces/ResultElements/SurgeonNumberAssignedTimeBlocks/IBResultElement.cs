namespace HM.HM1B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedTimeBlocks
{
    using HM.HM1B.A.E.O.Interfaces.IndexElements;

    public interface IBResultElement
    {
        IsIndexElement sIndexElement { get; }

        int Value { get; }
    }
}
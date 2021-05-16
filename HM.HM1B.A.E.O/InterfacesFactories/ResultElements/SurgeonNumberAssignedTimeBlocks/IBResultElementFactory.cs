namespace HM.HM1B.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedTimeBlocks
{
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedTimeBlocks;

    public interface IBResultElementFactory
    {
        IBResultElement Create(
            IsIndexElement sIndexElement,
            int value);
    }
}
namespace HM.HM1B.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;

    public interface IBResultElementFactory
    {
        IBResultElement Create(
            IjIndexElement jIndexElement,
            int value);
    }
}
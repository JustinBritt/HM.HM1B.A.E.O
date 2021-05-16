namespace HM.HM1B.A.E.O.InterfacesAbstractFactories
{
    public interface IResultElementsAbstractFactory
    {
        HM.HM1B.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks.IBResultElementFactory CreateBBarResultElementFactory();

        HM.HM1B.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedTimeBlocks.IBResultElementFactory CreateBsResultElementFactory();
    }
}
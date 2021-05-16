namespace HM.HM1B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM1B.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks;

    public interface ICalculationsAbstractFactory
    {
        IBCalculationFactory CreateBCalculationFactory();

        IBResultElementCalculationFactory CreateBResultElementCalculationFactory();
    }
}
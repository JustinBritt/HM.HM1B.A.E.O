namespace HM.HM1B.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM1B.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM1B.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedTimeBlocks;

    public interface IBCalculation
    {
        HM.HM1B.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedTimeBlocks.IB Calculate(
            IBResultElementCalculationFactory BResultElementCalculationFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IBResultElementFactory BResultElementFactory,
            IBFactory BFactory,
            IΔ Δ,
            HM.HM1B.A.E.O.Interfaces.Results.SurgeonNumberAssignedTimeBlocks.IB B);
    }
}
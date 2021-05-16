namespace HM.HM1B.A.E.O.Classes.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM1B.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM1B.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedTimeBlocks;

    internal sealed class BCalculation : IBCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BCalculation()
        {
        }

        public HM.HM1B.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedTimeBlocks.IB Calculate(
            IBResultElementCalculationFactory BResultElementCalculationFactory,
            IBResultElementFactory BResultElementFactory,
            IBFactory BFactory,
            IΔ Δ,
            HM.HM1B.A.E.O.Interfaces.Results.SurgeonNumberAssignedTimeBlocks.IB B)
        {
            return BFactory.Create(
                Δ.Value
                .Select(
                    i => BResultElementCalculationFactory.Create().Calculate(
                        BResultElementFactory,
                        i,
                        B))
                .ToImmutableList());
        }
    }
}
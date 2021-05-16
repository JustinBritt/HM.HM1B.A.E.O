namespace HM.HM1B.A.E.O.Classes.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using System.Linq;

    using log4net;

    using HM.HM1B.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.Results.SurgeonNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;

    internal sealed class BResultElementCalculation : IBResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BResultElementCalculation()
        {
        }

        public IBResultElement Calculate(
            IBResultElementFactory BResultElementFactory,
            IΔParameterElement ΔParameterElement,
            IB B)
        {
            return BResultElementFactory.Create(
                ΔParameterElement.jIndexElement,
                B
                .GetElementsAt(ΔParameterElement.Value)
                .Select(k => k.Value)
                .Sum());
        }
    }
}
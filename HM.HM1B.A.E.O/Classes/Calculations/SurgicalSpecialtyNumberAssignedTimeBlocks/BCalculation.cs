namespace HM.HM1B.A.E.O.Classes.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
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
            IRedBlackTreeFactory redBlackTreeFactory,
            IBResultElementFactory BResultElementFactory,
            IBFactory BFactory,
            IΔ Δ,
            HM.HM1B.A.E.O.Interfaces.Results.SurgeonNumberAssignedTimeBlocks.IB B)
        {
            RedBlackTree<IΔParameterElement, IBResultElement> redBlackTree = redBlackTreeFactory.Create<IΔParameterElement, IBResultElement>();

            foreach (IΔParameterElement ΔParameterElement in Δ.Value)
            {
                redBlackTree.Add(
                    ΔParameterElement,
                    BResultElementCalculationFactory.Create().Calculate(
                        BResultElementFactory,
                        ΔParameterElement,
                        B));
            }

            return BFactory.Create(
                redBlackTree);
        }
    }
}
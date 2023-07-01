namespace HM.HM1B.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedTimeBlocks;

    public interface IBFactory
    {
        IB Create(
            RedBlackTree<IΔParameterElement, IBResultElement> value);
    }
}
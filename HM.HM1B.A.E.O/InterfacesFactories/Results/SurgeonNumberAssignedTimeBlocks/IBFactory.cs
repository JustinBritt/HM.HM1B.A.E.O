namespace HM.HM1B.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedTimeBlocks
{
    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.Results.SurgeonNumberAssignedTimeBlocks;

    public interface IBFactory
    {
        IB Create(
            RedBlackTree<IsIndexElement, IBResultElement> value);
    }
}
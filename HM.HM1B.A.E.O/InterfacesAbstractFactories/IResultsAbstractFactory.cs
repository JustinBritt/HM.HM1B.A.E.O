namespace HM.HM1B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM1B.A.E.O.InterfacesFactories.Results.BestBound;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.Gap;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.NumberOfExploredNodes;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.ObjectiveValue;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.OverallWallTime;

    public interface IResultsAbstractFactory
    {
        HM.HM1B.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedTimeBlocks.IBFactory CreateBBarFactory();

        IBestBoundFactory CreateBestBoundFactory();

        HM.HM1B.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedTimeBlocks.IBFactory CreateBsFactory();

        HM.HM1B.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedTimeBlocks.IBVisitorFactory CreateBsVisitorFactory();

        IGapFactory CreateGapFactory();

        INumberOfExploredNodesFactory CreateNumberOfExploredNodesFactory();

        IObjectiveValueFactory CreateObjectiveValueFactory();

        IOverallWallTimeFactory CreateOverallWallTimeFactory();
    }
}
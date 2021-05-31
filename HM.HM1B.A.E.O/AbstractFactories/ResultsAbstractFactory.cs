namespace HM.HM1B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Factories.Results.BestBound;
    using HM.HM1B.A.E.O.Factories.Results.Gap;
    using HM.HM1B.A.E.O.Factories.Results.NumberOfExploredNodes;
    using HM.HM1B.A.E.O.Factories.Results.ObjectiveValue;
    using HM.HM1B.A.E.O.Factories.Results.OverallWallTime;
    using HM.HM1B.A.E.O.InterfacesAbstractFactories;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.BestBound;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.Gap;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.NumberOfExploredNodes;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.ObjectiveValue;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.OverallWallTime;

    internal sealed class ResultsAbstractFactory : IResultsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResultsAbstractFactory()
        {
        }

        public HM.HM1B.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedTimeBlocks.IBFactory CreateBBarFactory()
        {
            HM.HM1B.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedTimeBlocks.IBFactory factory = null;

            try
            {
                factory = new HM.HM1B.A.E.O.Factories.Results.SurgicalSpecialtyNumberAssignedTimeBlocks.BFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBestBoundFactory CreateBestBoundFactory()
        {
            IBestBoundFactory factory = null;

            try
            {
                factory = new BestBoundFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public HM.HM1B.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedTimeBlocks.IBFactory CreateBsFactory()
        {
            HM.HM1B.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedTimeBlocks.IBFactory factory = null;

            try
            {
                factory = new HM.HM1B.A.E.O.Factories.Results.SurgeonNumberAssignedTimeBlocks.BFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IGapFactory CreateGapFactory()
        {
            IGapFactory factory = null;

            try
            {
                factory = new GapFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public INumberOfExploredNodesFactory CreateNumberOfExploredNodesFactory()
        {
            INumberOfExploredNodesFactory factory = null;

            try
            {
                factory = new NumberOfExploredNodesFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IObjectiveValueFactory CreateObjectiveValueFactory()
        {
            IObjectiveValueFactory factory = null;

            try
            {
                factory = new ObjectiveValueFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IOverallWallTimeFactory CreateOverallWallTimeFactory()
        {
            IOverallWallTimeFactory factory = null;

            try
            {
                factory = new OverallWallTimeFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}
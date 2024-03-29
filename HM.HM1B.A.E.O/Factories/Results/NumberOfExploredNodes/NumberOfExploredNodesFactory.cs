﻿namespace HM.HM1B.A.E.O.Factories.Results.NumberOfExploredNodes
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Classes.Results.NumberOfExploredNodes;
    using HM.HM1B.A.E.O.Interfaces.Results.NumberOfExploredNodes;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.NumberOfExploredNodes;

    internal sealed class NumberOfExploredNodesFactory : INumberOfExploredNodesFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NumberOfExploredNodesFactory()
        {
        }

        public INumberOfExploredNodes Create(
            long value)
        {
            INumberOfExploredNodes result = null;

            try
            {
                result = new NumberOfExploredNodes(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}
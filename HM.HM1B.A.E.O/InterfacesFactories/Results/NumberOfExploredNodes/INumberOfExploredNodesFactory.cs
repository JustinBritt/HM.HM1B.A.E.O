﻿namespace HM.HM1B.A.E.O.InterfacesFactories.Results.NumberOfExploredNodes
{
    using HM.HM1B.A.E.O.Interfaces.Results.NumberOfExploredNodes;

    public interface INumberOfExploredNodesFactory
    {
        INumberOfExploredNodes Create(
            long value);
    }
}
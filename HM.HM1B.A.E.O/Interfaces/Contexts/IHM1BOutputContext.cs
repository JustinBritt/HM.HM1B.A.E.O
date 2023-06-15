namespace HM.HM1B.A.E.O.Interfaces.Contexts
{
    using System;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface IHM1BOutputContext
    {
        RedBlackTree<Organization, INullableValue<int>> SurgicalSpecialtyNumberAssignedTimeBlocks { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonNumberAssignedTimeBlocks { get; }

        INullableValue<decimal> BestBound { get; }

        INullableValue<decimal> Gap { get; }

        long NumberOfExploredNodes { get; }

        INullableValue<decimal> ObjectiveValue { get; }

        TimeSpan OverallWallTime { get; }
    }
}
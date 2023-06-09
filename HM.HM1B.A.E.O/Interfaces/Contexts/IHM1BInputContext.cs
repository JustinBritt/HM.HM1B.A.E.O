namespace HM.HM1B.A.E.O.Interfaces.Contexts
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface IHM1BInputContext
    {
        RedBlackTree<Organization, ImmutableSortedSet<Organization>> SurgicalSpecialties { get; }

        Bundle OperatingRooms { get; }

        Bundle Surgeons { get; }

        RedBlackTree<INullableValue<int>, FhirDateTime> PlanningHorizon { get; }

        ImmutableSortedSet<INullableValue<int>> Scenarios { get; }

        ImmutableSortedSet<INullableValue<int>> OperatingRoomServiceLevels { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> SurgeonServiceLevelNumberTimeBlocks { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonStrategicTargets { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> SurgeonScenarioMaximumNumberPatients { get; }

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioProbabilities { get; }

        INullableValue<int> OptimalOperatingRoomServiceLevel { get; }

        INullableValue<int> NextOperatingRoomServiceLevel { get; }

        RedBlackTree<FhirDateTime, INullableValue<bool>> DayAvailabilities { get; }

        RedBlackTree<Organization, INullableValue<decimal>> SurgeonPenaltyWeights { get; }
    }
}
namespace HM.HM1B.A.E.O.InterfacesFactories.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.Contexts;

    public interface IHM1BInputContextFactory
    {
        IHM1BInputContext Create(
            RedBlackTree<Organization, ImmutableSortedSet<Organization>> surgicalSpecialties,
            Bundle operatingRooms,
            Bundle surgeons,
            RedBlackTree<INullableValue<int>, FhirDateTime> planningHorizon,
            ImmutableSortedSet<INullableValue<int>> scenarios,
            ImmutableSortedSet<INullableValue<int>> operatingRoomServiceLevels,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> surgeonServiceLevelNumberTimeBlocks,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonStrategicTargets,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> surgeonScenarioMaximumNumberPatients,
            RedBlackTree<INullableValue<int>, INullableValue<decimal>> scenarioProbabilities,
            INullableValue<int> optimalOperatingRoomServiceLevel,
            INullableValue<int> nextOperatingRoomServiceLevel,
            ImmutableList<KeyValuePair<FhirDateTime, INullableValue<bool>>> dayAvailabilities,
            ImmutableList<KeyValuePair<Organization, INullableValue<decimal>>> surgeonPenaltyWeights);
    }
}
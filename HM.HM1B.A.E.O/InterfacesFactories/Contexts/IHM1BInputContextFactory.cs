namespace HM.HM1B.A.E.O.InterfacesFactories.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.Contexts;

    public interface IHM1BInputContextFactory
    {
        IHM1BInputContext Create(
            ImmutableList<Tuple<Organization, ImmutableList<Organization>>> surgicalSpecialties,
            Bundle operatingRooms,
            Bundle surgeons,
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> planningHorizon,
            ImmutableList<INullableValue<int>> scenarios,
            ImmutableList<INullableValue<int>> operatingRoomServiceLevels,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> surgeonServiceLevelNumberTimeBlocks,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonStrategicTargets,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> surgeonScenarioMaximumNumberPatients,
            ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<decimal>>> scenarioProbabilities,
            INullableValue<int> optimalOperatingRoomServiceLevel,
            INullableValue<int> nextOperatingRoomServiceLevel,
            ImmutableList<KeyValuePair<FhirDateTime, INullableValue<bool>>> dayAvailabilities,
            ImmutableList<KeyValuePair<Organization, INullableValue<decimal>>> surgeonPenaltyWeights);
    }
}
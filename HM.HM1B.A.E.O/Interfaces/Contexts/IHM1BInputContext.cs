namespace HM.HM1B.A.E.O.Interfaces.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    public interface IHM1BInputContext
    {
        ImmutableList<Tuple<Organization, ImmutableList<Organization>>> SurgicalSpecialties { get; }

        Bundle OperatingRooms { get; }

        Bundle Surgeons { get; }

        ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> PlanningHorizon { get; }

        ImmutableList<INullableValue<int>> Scenarios { get; }

        ImmutableList<INullableValue<int>> OperatingRoomServiceLevels { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonServiceLevelNumberTimeBlocks { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonStrategicTargets { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonScenarioMaximumNumberPatients { get; }

        ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<decimal>>> ScenarioProbabilities { get; }

        INullableValue<int> OptimalOperatingRoomServiceLevel { get; }

        INullableValue<int> NextOperatingRoomServiceLevel { get; }

        ImmutableList<KeyValuePair<FhirDateTime, INullableValue<bool>>> DayAvailabilities { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<decimal>>> SurgeonPenaltyWeights { get; }
    }
}
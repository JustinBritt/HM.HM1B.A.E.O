namespace HM.HM1B.A.E.O.Classes.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.Contexts;

    public sealed class HM1BInputContext : IHM1BInputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM1BInputContext(
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
            ImmutableList<KeyValuePair<Organization, INullableValue<decimal>>> surgeonPenaltyWeights)
        {
            this.SurgicalSpecialties = surgicalSpecialties;

            this.OperatingRooms = operatingRooms;

            this.Surgeons = surgeons;

            this.PlanningHorizon = planningHorizon;

            this.Scenarios = scenarios;

            this.OperatingRoomServiceLevels = operatingRoomServiceLevels;

            this.SurgeonServiceLevelNumberTimeBlocks = surgeonServiceLevelNumberTimeBlocks;

            this.SurgeonStrategicTargets = surgeonStrategicTargets;

            this.SurgeonScenarioMaximumNumberPatients = surgeonScenarioMaximumNumberPatients;

            this.ScenarioProbabilities = scenarioProbabilities;

            this.OptimalOperatingRoomServiceLevel = optimalOperatingRoomServiceLevel;

            this.NextOperatingRoomServiceLevel = nextOperatingRoomServiceLevel;

            this.DayAvailabilities = dayAvailabilities;

            this.SurgeonPenaltyWeights = surgeonPenaltyWeights;
        }

        public ImmutableList<Tuple<Organization, ImmutableList<Organization>>> SurgicalSpecialties { get; }

        public Bundle OperatingRooms { get; }

        public Bundle Surgeons { get; }

        public ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> PlanningHorizon { get; }

        public ImmutableList<INullableValue<int>> Scenarios { get; }

        public ImmutableList<INullableValue<int>> OperatingRoomServiceLevels { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonServiceLevelNumberTimeBlocks { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonStrategicTargets { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonScenarioMaximumNumberPatients { get; }

        public ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<decimal>>> ScenarioProbabilities { get; }

        public INullableValue<int> OptimalOperatingRoomServiceLevel { get; }

        public INullableValue<int> NextOperatingRoomServiceLevel { get; }

        public ImmutableList<KeyValuePair<FhirDateTime, INullableValue<bool>>> DayAvailabilities { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<decimal>>> SurgeonPenaltyWeights { get; }
    }
}
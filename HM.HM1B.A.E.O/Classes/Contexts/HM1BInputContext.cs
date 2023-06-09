namespace HM.HM1B.A.E.O.Classes.Contexts
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.Contexts;

    public sealed class HM1BInputContext : IHM1BInputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM1BInputContext(
            RedBlackTree<Organization, ImmutableSortedSet<Organization>> surgicalSpecialties,
            Bundle operatingRooms,
            Bundle surgeons,
            RedBlackTree<INullableValue<int>, FhirDateTime> planningHorizon,
            ImmutableSortedSet<INullableValue<int>> scenarios,
            ImmutableSortedSet<INullableValue<int>> operatingRoomServiceLevels,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> surgeonServiceLevelNumberTimeBlocks,
            RedBlackTree<Organization, INullableValue<int>> surgeonStrategicTargets,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> surgeonScenarioMaximumNumberPatients,
            RedBlackTree<INullableValue<int>, INullableValue<decimal>> scenarioProbabilities,
            INullableValue<int> optimalOperatingRoomServiceLevel,
            INullableValue<int> nextOperatingRoomServiceLevel,
            RedBlackTree<FhirDateTime, INullableValue<bool>> dayAvailabilities,
            RedBlackTree<Organization, INullableValue<decimal>> surgeonPenaltyWeights)
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

        public RedBlackTree<Organization, ImmutableSortedSet<Organization>> SurgicalSpecialties { get; }

        public Bundle OperatingRooms { get; }

        public Bundle Surgeons { get; }

        public RedBlackTree<INullableValue<int>, FhirDateTime> PlanningHorizon { get; }

        public ImmutableSortedSet<INullableValue<int>> Scenarios { get; }

        public ImmutableSortedSet<INullableValue<int>> OperatingRoomServiceLevels { get; }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> SurgeonServiceLevelNumberTimeBlocks { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonStrategicTargets { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonScenarioMaximumNumberPatients { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioProbabilities { get; }

        public INullableValue<int> OptimalOperatingRoomServiceLevel { get; }

        public INullableValue<int> NextOperatingRoomServiceLevel { get; }

        public RedBlackTree<FhirDateTime, INullableValue<bool>> DayAvailabilities { get; }

        public RedBlackTree<Organization, INullableValue<decimal>> SurgeonPenaltyWeights { get; }
    }
}
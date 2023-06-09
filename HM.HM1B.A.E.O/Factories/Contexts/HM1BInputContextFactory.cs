namespace HM.HM1B.A.E.O.Factories.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Classes.Contexts;
    using HM.HM1B.A.E.O.Interfaces.Contexts;
    using HM.HM1B.A.E.O.InterfacesFactories.Contexts;

    internal sealed class HM1BInputContextFactory : IHM1BInputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM1BInputContextFactory()
        {
        }

        public IHM1BInputContext Create(
            RedBlackTree<Organization, ImmutableSortedSet<Organization>> surgicalSpecialties,
            Bundle operatingRooms,
            Bundle surgeons,
            RedBlackTree<INullableValue<int>, FhirDateTime> planningHorizon,
            ImmutableSortedSet<INullableValue<int>> scenarios,
            ImmutableSortedSet<INullableValue<int>> operatingRoomServiceLevels,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> surgeonServiceLevelNumberTimeBlocks,
            RedBlackTree<Organization, INullableValue<int>> surgeonStrategicTargets,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> surgeonScenarioMaximumNumberPatients,
            RedBlackTree<INullableValue<int>, INullableValue<decimal>> scenarioProbabilities,
            INullableValue<int> optimalOperatingRoomServiceLevel,
            INullableValue<int> nextOperatingRoomServiceLevel,
            RedBlackTree<FhirDateTime, INullableValue<bool>> dayAvailabilities,
            ImmutableList<KeyValuePair<Organization, INullableValue<decimal>>> surgeonPenaltyWeights)
        {
            IHM1BInputContext context = null;

            try
            {
                context = new HM1BInputContext(
                    surgicalSpecialties,
                    operatingRooms,
                    surgeons,
                    planningHorizon,
                    scenarios,
                    operatingRoomServiceLevels,
                    surgeonServiceLevelNumberTimeBlocks,
                    surgeonStrategicTargets,
                    surgeonScenarioMaximumNumberPatients,
                    scenarioProbabilities,
                    optimalOperatingRoomServiceLevel,
                    nextOperatingRoomServiceLevel,
                    dayAvailabilities,
                    surgeonPenaltyWeights);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return context;
        }
    }
}
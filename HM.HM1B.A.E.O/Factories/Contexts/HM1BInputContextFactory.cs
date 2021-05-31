namespace HM.HM1B.A.E.O.Factories.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

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
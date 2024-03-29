﻿namespace HM.HM1B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM1B.A.E.O.InterfacesFactories.Contexts;

    public interface IContextsAbstractFactory
    {
        IDayAvailabilitiesVisitorFactory CreateDayAvailabilitiesVisitorFactory();

        IHM1BInputContextFactory CreateHM1BInputContextFactory();

        IHM1BOutputContextFactory CreateHM1BOutputContextFactory();

        IPlanningHorizonVisitorFactory CreatePlanningHorizonVisitorFactory();

        IScenarioProbabilitiesVisitorFactory CreateScenarioProbabilitiesVisitorFactory();

        ISurgeonPenaltyWeightsVisitorFactory CreateSurgeonPenaltyWeightsVisitorFactory();

        ISurgeonScenarioMaximumNumberPatientsInnerVisitorFactory CreateSurgeonScenarioMaximumNumberPatientsInnerVisitorFactory();

        ISurgeonScenarioMaximumNumberPatientsOuterVisitorFactory CreateSurgeonScenarioMaximumNumberPatientsOuterVisitorFactory();

        ISurgeonServiceLevelNumberTimeBlocksInnerVisitorFactory CreateSurgeonServiceLevelNumberTimeBlocksInnerVisitorFactory();

        ISurgeonServiceLevelNumberTimeBlocksOuterVisitorFactory CreateSurgeonServiceLevelNumberTimeBlocksOuterVisitorFactory();

        ISurgeonStrategicTargetsVisitorFactory CreateSurgeonStrategicTargetsVisitorFactory();

        ISurgicalSpecialtiesVisitorFactory CreateSurgicalSpecialtiesVisitorFactory();
    }
}
namespace HM.HM1B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.DayAvailabilities;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.Surgeries;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;

    public interface IParameterElementsAbstractFactory
    {
        IAParameterElementFactory CreateAParameterElementFactory();

        INParameterElementFactory CreateNParameterElementFactory();

        InParameterElementFactory CreatenParameterElementFactory();

        IΔParameterElementFactory CreateΔParameterElementFactory();

        IΡParameterElementFactory CreateΡParameterElementFactory();

        IψParameterElementFactory CreateψParameterElementFactory();

        IωParameterElementFactory CreateωParameterElementFactory();
    }
}
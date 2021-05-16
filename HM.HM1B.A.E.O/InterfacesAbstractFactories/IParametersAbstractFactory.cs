namespace HM.HM1B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.DayAvailabilities;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.ScenarioProbabilities;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.ServiceLevelAssignments;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.Surgeries;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties;

    public interface IParametersAbstractFactory
    {
        IAFactory CreateAFactory();

        INFactory CreateNFactory();

        InFactory CreatenFactory();

        IΔFactory CreateΔFactory();

        IΡFactory CreateΡFactory();

        Iυ1StarFactory Createυ1StarFactory();

        Iυ1StarPlus1Factory Createυ1StarPlus1Factory();

        IψFactory CreateψFactory();

        IωFactory CreateωFactory();
    }
}
namespace HM.HM1B.A.E.O.InterfacesFactories.ObjectiveFunctions
{
    using HM.HM1B.A.E.O.Interfaces.CrossJoins;
    using HM.HM1B.A.E.O.Interfaces.ObjectiveFunctions;
    using HM.HM1B.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.Interfaces.Variables;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    public interface IObjectiveFunction111Factory
    {
        IObjectiveFunction111 Create(
            IObjectiveFactory objectiveFactory,
            IsΛ sΛ,
            IΡ Ρ,
            Iω ω,
            Ie1Minus e1Minus,
            Ie1Plus e1Plus);
    }
}
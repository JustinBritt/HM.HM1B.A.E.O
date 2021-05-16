namespace HM.HM1B.A.E.O.InterfacesFactories.SolverConfigurations
{
    using HM.HM1B.A.E.O.Interfaces.SolverConfigurations;

    public interface ISolverConfigurationFactory
    {
        ISolverConfiguration Create(
            OPTANO.Modeling.Optimization.SolverConfiguration solverConfiguration);
    }
}
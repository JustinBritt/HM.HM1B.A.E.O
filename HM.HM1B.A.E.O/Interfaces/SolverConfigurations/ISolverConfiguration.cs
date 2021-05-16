namespace HM.HM1B.A.E.O.Interfaces.SolverConfigurations
{
    using OPTANO.Modeling.Optimization;

    public interface ISolverConfiguration
    {
        SolverConfiguration Value { get; }
    }
}
namespace HM.HM1B.A.E.O.Interfaces.Exports
{
    using System.Threading.Tasks;

    using HM.HM1B.A.E.O.Enums;
    using HM.HM1B.A.E.O.InterfacesAbstractFactories;
    using HM.HM1B.A.E.O.Interfaces.Configurations;
    using HM.HM1B.A.E.O.Interfaces.Contexts;
    using HM.HM1B.A.E.O.Interfaces.SolverConfigurations;

    public interface IHM1BExport
    {
        Task<IHM1BOutputContext> Solve(
            IAbstractFactory abstractFactory,
            IHM1BConfiguration HM1BConfiguration,
            IHM1BInputContext HM1BInputContext,
            ISolverConfiguration solverConfiguration,
            HM1BEncodingEnum HM1BEncodingEnum);
    }
}
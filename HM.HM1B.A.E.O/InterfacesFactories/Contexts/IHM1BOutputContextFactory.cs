namespace HM.HM1B.A.E.O.InterfacesFactories.Contexts
{
    using OPTANO.Modeling.Optimization;

    using HM.HM1B.A.E.O.InterfacesAbstractFactories;
    using HM.HM1B.A.E.O.Interfaces.Contexts;
    using HM.HM1B.A.E.O.Interfaces.Models;

    public interface IHM1BOutputContextFactory
    {
        IHM1BOutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IHM1BModel HM1BModel,
            Solution solution);
    }
}
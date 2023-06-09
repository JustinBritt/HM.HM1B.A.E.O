namespace HM.HM1B.A.E.O.Classes.Exports
{
    using System.Threading.Tasks;

    using log4net;

    using HM.HM1B.A.E.O.Enums;
    using HM.HM1B.A.E.O.InterfacesAbstractFactories;
    using HM.HM1B.A.E.O.Interfaces.Configurations;
    using HM.HM1B.A.E.O.Interfaces.Contexts;
    using HM.HM1B.A.E.O.Interfaces.Exports;
    using HM.HM1B.A.E.O.Interfaces.SolverConfigurations;

    public sealed class HM1BExport : IHM1BExport
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM1BExport()
        {
        }

        public Task<IHM1BOutputContext> Solve(
            IAbstractFactory abstractFactory,
            IHM1BConfiguration HM1BConfiguration,
            IHM1BInputContext HM1BInputContext,
            ISolverConfiguration solverConfiguration,
            HM1BEncodingEnum HM1BEncodingEnum)
        {
            return abstractFactory.CreateSolutionsAbstractFactory().CreateHM1BSolutionFactory().Create().Solve(
                abstractFactory.CreateCalculationsAbstractFactory(),
                abstractFactory.CreateComparersAbstractFactory(),
                abstractFactory.CreateConstraintElementsAbstractFactory(),
                abstractFactory.CreateConstraintsAbstractFactory(),
                abstractFactory.CreateContextsAbstractFactory(),
                abstractFactory.CreateCrossJoinElementsAbstractFactory(),
                abstractFactory.CreateCrossJoinsAbstractFactory(),
                abstractFactory.CreateDependenciesAbstractFactory(),
                abstractFactory.CreateIndexElementsAbstractFactory(),
                abstractFactory.CreateIndicesAbstractFactory(),
                abstractFactory.CreateModelsAbstractFactory(),
                abstractFactory.CreateObjectiveFunctionsAbstractFactory(),
                abstractFactory.CreateParameterElementsAbstractFactory(),
                abstractFactory.CreateParametersAbstractFactory(),
                abstractFactory.CreateResultElementsAbstractFactory(),
                abstractFactory.CreateResultsAbstractFactory(),
                abstractFactory.CreateVariablesAbstractFactory(),
                HM1BConfiguration,
                HM1BInputContext,
                solverConfiguration,
                HM1BEncodingEnum);
        }
    }
}
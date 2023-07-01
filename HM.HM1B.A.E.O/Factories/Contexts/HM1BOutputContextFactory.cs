namespace HM.HM1B.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM1B.A.E.O.Classes.Contexts;
    using HM.HM1B.A.E.O.InterfacesAbstractFactories;
    using HM.HM1B.A.E.O.Interfaces.Contexts;
    using HM.HM1B.A.E.O.Interfaces.Models;
    using HM.HM1B.A.E.O.InterfacesFactories.Contexts;
   
    internal sealed class HM1BOutputContextFactory : IHM1BOutputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM1BOutputContextFactory()
        {
        }

        public IHM1BOutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IComparersAbstractFactory comparersAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IHM1BModel HM1BModel,
            Solution solution)
        {
            IHM1BOutputContext context = null;

            try
            {
                context = new HM1BOutputContext(
                    calculationsAbstractFactory,
                    comparersAbstractFactory,
                    dependenciesAbstractFactory,
                    resultElementsAbstractFactory,
                    resultsAbstractFactory,
                    HM1BModel,
                    solution);
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
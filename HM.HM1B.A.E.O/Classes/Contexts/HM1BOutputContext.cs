namespace HM.HM1B.A.E.O.Classes.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using HM.HM1B.A.E.O.InterfacesAbstractFactories;
    using HM.HM1B.A.E.O.Interfaces.Contexts;
    using HM.HM1B.A.E.O.Interfaces.Models;

    internal sealed class HM1BOutputContext : IHM1BOutputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM1BOutputContext(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IComparersAbstractFactory comparersAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IHM1BModel HM1BModel,
            Solution solution)
        {
            // BestBound
            this.BestBound = resultsAbstractFactory.CreateBestBoundFactory().Create(
                (decimal)solution.BestBound)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // Gap
            this.Gap = resultsAbstractFactory.CreateGapFactory().Create(
                (decimal)solution.Gap)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // NumberOfExploredNodes
            this.NumberOfExploredNodes = resultsAbstractFactory.CreateNumberOfExploredNodesFactory().Create(
                solution.NumberOfExploredNodes)
                .GetValueForOutputContext();

            // ObjectiveValue
            this.ObjectiveValue = resultsAbstractFactory.CreateObjectiveValueFactory().Create(
                (decimal)solution.ObjectiveValues.SingleOrDefault().Value)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // OverallWallTime
            this.OverallWallTime = resultsAbstractFactory.CreateOverallWallTimeFactory().Create(
                solution.OverallWallTime)
                .GetValueForOutputContext();

            // B(s)
            HM.HM1B.A.E.O.Interfaces.Results.SurgeonNumberAssignedTimeBlocks.IB Bs = HM1BModel.B.GetElementsAt(
                resultElementsAbstractFactory.CreateBsResultElementFactory(),
                resultsAbstractFactory.CreateBsFactory(),
                HM1BModel.s);

            this.SurgeonNumberAssignedTimeBlocks = Bs.GetValueForOutputContext(
                comparersAbstractFactory.CreateOrganizationComparerFactory(),
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                resultsAbstractFactory.CreateBsVisitorFactory());

            // BBar(j)
            this.SurgicalSpecialtyNumberAssignedTimeBlocks = calculationsAbstractFactory.CreateBCalculationFactory().Create().Calculate(
                calculationsAbstractFactory.CreateBResultElementCalculationFactory(),
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                resultElementsAbstractFactory.CreateBBarResultElementFactory(),
                resultsAbstractFactory.CreateBBarFactory(),
                HM1BModel.Δ,
                Bs)
                .GetValueForOutputContext(
                comparersAbstractFactory.CreateOrganizationComparerFactory(),   
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                resultsAbstractFactory.CreateBBarVisitorFactory());
        }

        public RedBlackTree<Organization, INullableValue<int>> SurgicalSpecialtyNumberAssignedTimeBlocks { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonNumberAssignedTimeBlocks { get; }

        public INullableValue<decimal> BestBound { get; }

        public INullableValue<decimal> Gap { get; }

        public long NumberOfExploredNodes { get; }

        public INullableValue<decimal> ObjectiveValue { get; }

        public TimeSpan OverallWallTime { get; }
    }
}
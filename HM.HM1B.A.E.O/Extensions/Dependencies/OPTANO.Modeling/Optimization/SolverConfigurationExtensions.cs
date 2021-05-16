namespace HM.HM1B.A.E.O.Extensions.Dependencies.OPTANO.Modeling.Optimization
{
    using System;
    using System.Reflection;

    public static class SolverConfigurationExtensions
    {
        public static global::OPTANO.Modeling.Optimization.SolverConfiguration WithConcurrentMIP(
            this global::OPTANO.Modeling.Optimization.SolverConfiguration solverConfiguration,
            int concurrentMIP)
        {
            solverConfiguration
                .GetType()
                .GetProperty(nameof(global::OPTANO.Modeling.Optimization.Solver.Gurobi900.GurobiSolverConfiguration.ConcurrentMIP))?
                .SetValue(
                    solverConfiguration,
                    concurrentMIP);

            return solverConfiguration;
        }

        public static global::OPTANO.Modeling.Optimization.SolverConfiguration WithIterationLimit(
            this global::OPTANO.Modeling.Optimization.SolverConfiguration solverConfiguration,
            double iterationLimit)
        {
            solverConfiguration
                .GetType()
                .GetProperty(nameof(global::OPTANO.Modeling.Optimization.Solver.Gurobi900.GurobiSolverConfiguration.IterationLimit))?
                .SetValue(
                    solverConfiguration,
                    iterationLimit);

            return solverConfiguration;
        }

        public static global::OPTANO.Modeling.Optimization.SolverConfiguration WithTimeLimit(
            this global::OPTANO.Modeling.Optimization.SolverConfiguration solverConfiguration,
            double timeLimit)
        {
            solverConfiguration.TimeLimit = timeLimit;

            return solverConfiguration;
        }
    }
}
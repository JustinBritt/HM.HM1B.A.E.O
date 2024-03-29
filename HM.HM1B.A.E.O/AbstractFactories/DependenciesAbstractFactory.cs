﻿namespace HM.HM1B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Factories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM1B.A.E.O.Factories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM1B.A.E.O.Factories.Dependencies.OPTANO.Modeling.Optimization;
    using HM.HM1B.A.E.O.Factories.Dependencies.OPTANO.Modeling.Optimization.Configuration;
    using HM.HM1B.A.E.O.InterfacesAbstractFactories;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization.Configuration;

    internal sealed class DependenciesAbstractFactory : IDependenciesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DependenciesAbstractFactory()
        {
        }

        public IConfigurationFactory CreateConfigurationFactory()
        {
            IConfigurationFactory factory = null;

            try
            {
                factory = new ConfigurationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IModelFactory CreateModelFactory()
        {
            IModelFactory factory = null;

            try
            {
                factory = new ModelFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IModelScopeFactory CreateModelScopeFactory()
        {
            IModelScopeFactory factory = null;

            try
            {
                factory = new ModelScopeFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public INullableValueFactory CreateNullableValueFactory()
        {
            INullableValueFactory factory = null;

            try
            {
                factory = new NullableValueFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IObjectiveFactory CreateObjectiveFactory()
        {
            IObjectiveFactory factory = null;

            try
            {
                factory = new ObjectiveFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IRedBlackTreeFactory CreateRedBlackTreeFactory()
        {
            IRedBlackTreeFactory factory = null;

            try
            {
                factory = new RedBlackTreeFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISolverFactory CreateSolverFactory()
        {
            ISolverFactory factory = null;

            try
            {
                factory = new SolverFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISolverConfigurationFactory CreateSolverConfigurationFactory()
        {
            ISolverConfigurationFactory factory = null;

            try
            {
                factory = new SolverConfigurationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVariableFactory CreateVariableFactory()
        {
            IVariableFactory factory = null;

            try
            {
                factory = new VariableFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVariableCollectionFactory CreateVariableCollectionFactory()
        {
            IVariableCollectionFactory factory = null;

            try
            {
                factory = new VariableCollectionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}
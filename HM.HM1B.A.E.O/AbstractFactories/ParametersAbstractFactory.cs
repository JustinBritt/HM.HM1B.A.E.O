namespace HM.HM1B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Factories.Parameters.DayAvailabilities;
    using HM.HM1B.A.E.O.Factories.Parameters.ScenarioProbabilities;
    using HM.HM1B.A.E.O.Factories.Parameters.ServiceLevelAssignments;
    using HM.HM1B.A.E.O.Factories.Parameters.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.Factories.Parameters.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.Factories.Parameters.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.Factories.Parameters.Surgeries;
    using HM.HM1B.A.E.O.Factories.Parameters.SurgicalSpecialties;
    using HM.HM1B.A.E.O.InterfacesAbstractFactories;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.DayAvailabilities;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.ScenarioProbabilities;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.ServiceLevelAssignments;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.Surgeries;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties;

    internal sealed class ParametersAbstractFactory : IParametersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParametersAbstractFactory()
        {
        }

        public IAFactory CreateAFactory()
        {
            IAFactory factory = null;

            try
            {
                factory = new AFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public INFactory CreateNFactory()
        {
            INFactory factory = null;

            try
            {
                factory = new NFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public InFactory CreatenFactory()
        {
            InFactory factory = null;

            try
            {
                factory = new nFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΔFactory CreateΔFactory()
        {
            IΔFactory factory = null;

            try
            {
                factory = new ΔFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΡFactory CreateΡFactory()
        {
            IΡFactory factory = null;

            try
            {
                factory = new ΡFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Iυ1StarFactory Createυ1StarFactory()
        {
            Iυ1StarFactory factory = null;

            try
            {
                factory = new υ1StarFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Iυ1StarPlus1Factory Createυ1StarPlus1Factory()
        {
            Iυ1StarPlus1Factory factory = null;

            try
            {
                factory = new υ1StarPlus1Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IψFactory CreateψFactory()
        {
            IψFactory factory = null;

            try
            {
                factory = new ψFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IωFactory CreateωFactory()
        {
            IωFactory factory = null;

            try
            {
                factory = new ωFactory();
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
namespace HM.HM1B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Factories.ParameterElements.DayAvailabilities;
    using HM.HM1B.A.E.O.Factories.ParameterElements.ScenarioProbabilities;
    using HM.HM1B.A.E.O.Factories.ParameterElements.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.Factories.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.Factories.ParameterElements.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.Factories.ParameterElements.Surgeries;
    using HM.HM1B.A.E.O.Factories.ParameterElements.SurgicalSpecialties;
    using HM.HM1B.A.E.O.InterfacesAbstractFactories;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.DayAvailabilities;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.Surgeries;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;

    internal sealed class ParameterElementsAbstractFactory : IParameterElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParameterElementsAbstractFactory()
        {
        }

        public IAParameterElementFactory CreateAParameterElementFactory()
        {
            IAParameterElementFactory factory = null;

            try
            {
                factory = new AParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public INParameterElementFactory CreateNParameterElementFactory()
        {
            INParameterElementFactory factory = null;

            try
            {
                factory = new NParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public InParameterElementFactory CreatenParameterElementFactory()
        {
            InParameterElementFactory factory = null;

            try
            {
                factory = new nParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΔParameterElementFactory CreateΔParameterElementFactory()
        {
            IΔParameterElementFactory factory = null;

            try
            {
                factory = new ΔParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΡParameterElementFactory CreateΡParameterElementFactory()
        {
            IΡParameterElementFactory factory = null;

            try
            {
                factory = new ΡParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IψParameterElementFactory CreateψParameterElementFactory()
        {
            IψParameterElementFactory factory = null;

            try
            {
                factory = new ψParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IωParameterElementFactory CreateωParameterElementFactory()
        {
            IωParameterElementFactory factory = null;

            try
            {
                factory = new ωParameterElementFactory();
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
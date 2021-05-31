namespace HM.HM1B.A.E.O.Factories.ObjectiveFunctions
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Classes.ObjectiveFunctions;
    using HM.HM1B.A.E.O.Interfaces.CrossJoins;
    using HM.HM1B.A.E.O.Interfaces.ObjectiveFunctions;
    using HM.HM1B.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.Interfaces.Variables;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using HM.HM1B.A.E.O.InterfacesFactories.ObjectiveFunctions;

    internal sealed class ObjectiveFunction100Factory : IObjectiveFunction100Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFunction100Factory()
        {
        }

        public IObjectiveFunction100 Create(
            IObjectiveFactory objectiveFactory,
            IsΛ sΛ,
            IΡ Ρ,
            Iω ω,
            Ie1Minus e1Minus)
        {
            IObjectiveFunction100 objectiveFunction = null;

            try
            {
                objectiveFunction = new ObjectiveFunction100(
                    objectiveFactory,
                    sΛ,
                    Ρ,
                    ω,
                    e1Minus);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return objectiveFunction;
        }
    }
}
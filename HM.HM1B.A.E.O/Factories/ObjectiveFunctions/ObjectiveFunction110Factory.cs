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

    internal sealed class ObjectiveFunction110Factory : IObjectiveFunction110Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFunction110Factory()
        {
        }

        public IObjectiveFunction110 Create(
            IObjectiveFactory objectiveFactory,
            IsΛ sΛ,
            IΡ Ρ,
            Iω ω,
            Ie1Minus e1Minus,
            Ie1Plus e1Plus)
        {
            IObjectiveFunction110 objectiveFunction = null;

            try
            {
                objectiveFunction = new ObjectiveFunction110(
                    objectiveFactory,
                    sΛ,
                    Ρ,
                    ω,
                    e1Minus,
                    e1Plus);
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
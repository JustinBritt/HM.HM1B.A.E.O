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

    internal sealed class ObjectiveFunction111Factory : IObjectiveFunction111Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFunction111Factory()
        {
        }

        public IObjectiveFunction111 Create(
            IObjectiveFactory objectiveFactory,
            IsΛ sΛ,
            IΡ Ρ,
            Iω ω,
            Ie1Minus e1Minus,
            Ie1Plus e1Plus)
        {
            IObjectiveFunction111 objectiveFunction = null;

            try
            {
                objectiveFunction = new ObjectiveFunction111(
                    objectiveFactory,
                    sΛ,
                    Ρ,
                    ω,
                    e1Minus,
                    e1Plus);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return objectiveFunction;
        }
    }
}
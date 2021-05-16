namespace HM.HM1B.A.E.O.Classes.ObjectiveFunctions
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using HM.HM1B.A.E.O.Interfaces.CrossJoins;
    using HM.HM1B.A.E.O.Interfaces.ObjectiveFunctions;
    using HM.HM1B.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.Interfaces.Variables;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class ObjectiveFunction110 : IObjectiveFunction110
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFunction110(
            IObjectiveFactory objectiveFactory,
            IsΛ sΛ,
            IΡ Ρ,
            Iω ω,
            Ie1Minus e1Minus,
            Ie1Plus e1Plus)
        {
            Expression expression = Expression.Sum(
                sΛ.Value
                .Select(
                    x => (double)Ρ.GetElementAtAsdecimal(
                        x.ΛIndexElement)
                    *
                    (double)ω.GetElementAtAsdecimal(
                        x.sIndexElement)
                    *
                    (e1Minus.Value[x.sIndexElement, x.ΛIndexElement] 
                    + 
                    e1Plus.Value[x.sIndexElement, x.ΛIndexElement])));

            Objective objective = objectiveFactory.Create(
                expression,
                ObjectiveSense.Minimize);

            this.Value = objective;
        }

        public Objective Value { get; }
    }
}
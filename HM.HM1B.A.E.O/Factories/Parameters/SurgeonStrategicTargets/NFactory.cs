namespace HM.HM1B.A.E.O.Factories.Parameters.SurgeonStrategicTargets
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Classes.Parameters.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.SurgeonStrategicTargets;

    internal sealed class NFactory : INFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NFactory()
        {
        }

        public IN Create(
            RedBlackTree<IsIndexElement, INParameterElement> value)
        {
            IN parameter = null;

            try
            {
                parameter = new N(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}
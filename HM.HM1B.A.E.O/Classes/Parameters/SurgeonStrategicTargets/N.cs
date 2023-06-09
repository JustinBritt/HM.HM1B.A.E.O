namespace HM.HM1B.A.E.O.Classes.Parameters.SurgeonStrategicTargets
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonStrategicTargets;

    internal sealed class N : IN
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public N(
            RedBlackTree<IsIndexElement, INParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, INParameterElement> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement)
        {
            return this.Value[sIndexElement].Value.Value.Value;
        }
    }
}
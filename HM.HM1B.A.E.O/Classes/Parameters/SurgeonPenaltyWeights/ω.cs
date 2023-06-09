namespace HM.HM1B.A.E.O.Classes.Parameters.SurgeonPenaltyWeights
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonPenaltyWeights;

    internal sealed class ω : Iω
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ω(
            RedBlackTree<IsIndexElement, IωParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, IωParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement)
        {
            return this.Value[sIndexElement].Value.Value.Value;
        }
    }
}
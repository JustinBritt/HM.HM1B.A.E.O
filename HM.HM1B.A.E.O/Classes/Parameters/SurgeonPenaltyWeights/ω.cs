namespace HM.HM1B.A.E.O.Classes.Parameters.SurgeonPenaltyWeights
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonPenaltyWeights;

    internal sealed class ω : Iω
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ω(
            ImmutableList<IωParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IωParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}
namespace HM.HM1B.A.E.O.Classes.Parameters.SurgeonStrategicTargets
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonStrategicTargets;

    internal sealed class N : IN
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public N(
            ImmutableList<INParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<INParameterElement> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}
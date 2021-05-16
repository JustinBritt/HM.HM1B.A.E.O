namespace HM.HM1B.A.E.O.Classes.Parameters.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgicalSpecialties;

    internal sealed class Δ : IΔ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Δ(
            ImmutableList<IΔParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IΔParameterElement> Value { get; }
    }
}
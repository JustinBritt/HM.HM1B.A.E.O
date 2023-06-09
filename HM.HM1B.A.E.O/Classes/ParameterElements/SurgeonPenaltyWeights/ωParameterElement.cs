namespace HM.HM1B.A.E.O.Classes.ParameterElements.SurgeonPenaltyWeights
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonPenaltyWeights;

    internal sealed class ωParameterElement : IωParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ωParameterElement(
            IsIndexElement sIndexElement,
            INullableValue<decimal> value)
        {
            this.sIndexElement = sIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public INullableValue<decimal> Value { get; }
    }
}
namespace HM.HM1B.A.E.O.Classes.ParameterElements.SurgeonStrategicTargets
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonStrategicTargets;

    internal sealed class NParameterElement : INParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NParameterElement(
            IsIndexElement sIndexElement,
            INullableValue<int> value)
        {
            this.sIndexElement = sIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public INullableValue<int> Value { get; }
    }
}
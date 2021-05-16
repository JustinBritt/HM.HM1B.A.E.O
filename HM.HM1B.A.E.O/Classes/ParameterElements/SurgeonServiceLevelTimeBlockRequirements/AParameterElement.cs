namespace HM.HM1B.A.E.O.Classes.ParameterElements.SurgeonServiceLevelTimeBlockRequirements
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;

    internal sealed class AParameterElement : IAParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AParameterElement(
            IsIndexElement sIndexElement,
            Iυ1IndexElement υ1IndexElement,
            PositiveInt value)
        {
            this.sIndexElement = sIndexElement;

            this.υ1IndexElement = υ1IndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public Iυ1IndexElement υ1IndexElement { get; }

        public PositiveInt Value { get; }
    }
}
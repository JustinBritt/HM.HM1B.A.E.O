namespace HM.HM1B.A.E.O.Classes.IndexElements
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;

    internal sealed class ΛIndexElement : IΛIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΛIndexElement(
            INullableValue<int> value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the scenario.
        /// </summary>
        public INullableValue<int> Value { get; }

        public int CompareTo(
            IΛIndexElement other)
        {
            return this.Value.Value.Value.CompareTo(
                other.Value.Value.Value);
        }
    }
}
namespace HM.HM1B.A.E.O.Factories.ParameterElements.SurgeonPenaltyWeights
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Classes.ParameterElements.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonPenaltyWeights;

    internal sealed class ωParameterElementFactory : IωParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ωParameterElementFactory()
        {
        }

        public IωParameterElement Create(
            IsIndexElement sIndexElement,
            FhirDecimal value)
        {
            IωParameterElement parameterElement = null;

            try
            {
                parameterElement = new ωParameterElement(
                    sIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameterElement;
        }
    }
}
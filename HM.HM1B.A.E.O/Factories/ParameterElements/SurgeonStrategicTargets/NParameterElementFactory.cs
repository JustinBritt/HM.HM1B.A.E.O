namespace HM.HM1B.A.E.O.Factories.ParameterElements.SurgeonStrategicTargets
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Classes.ParameterElements.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonStrategicTargets;

    internal sealed class NParameterElementFactory : INParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NParameterElementFactory()
        {
        }

        public INParameterElement Create(
            IsIndexElement sIndexElement,
            PositiveInt value)
        {
            INParameterElement parameterElement = null;

            try
            {
                parameterElement = new NParameterElement(
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
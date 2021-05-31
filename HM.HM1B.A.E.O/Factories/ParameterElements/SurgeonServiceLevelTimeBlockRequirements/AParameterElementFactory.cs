namespace HM.HM1B.A.E.O.Factories.ParameterElements.SurgeonServiceLevelTimeBlockRequirements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Classes.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;

    internal sealed class AParameterElementFactory : IAParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AParameterElementFactory()
        {
        }

        public IAParameterElement Create(
            IsIndexElement sIndexElement,
            Iυ1IndexElement υ1IndexElement,
            PositiveInt value)
        {
            IAParameterElement parameterElement = null;

            try
            {
                parameterElement = new AParameterElement(
                    sIndexElement,
                    υ1IndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameterElement;
        }
    }
}
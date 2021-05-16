namespace HM.HM1B.A.E.O.Factories.Parameters.SurgeonServiceLevelTimeBlockRequirements
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM1B.A.E.O.Classes.Parameters.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.SurgeonServiceLevelTimeBlockRequirements;

    internal sealed class AFactory : IAFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AFactory()
        {
        }

        public IA Create(
            ImmutableList<IAParameterElement> value)
        {
            IA parameter = null;

            try
            {
                parameter = new A(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameter;
        }
    }
}
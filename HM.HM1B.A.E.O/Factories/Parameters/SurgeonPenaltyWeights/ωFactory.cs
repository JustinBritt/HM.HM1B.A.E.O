﻿namespace HM.HM1B.A.E.O.Factories.Parameters.SurgeonPenaltyWeights
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM1B.A.E.O.Classes.Parameters.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.SurgeonPenaltyWeights;

    internal sealed class ωFactory : IωFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ωFactory()
        {
        }

        public Iω Create(
            ImmutableList<IωParameterElement> value)
        {
            Iω parameter = null;

            try
            {
                parameter = new ω(
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
﻿namespace HM.HM1B.A.E.O.Classes.IndexElements
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;

    internal sealed class υ1IndexElement : Iυ1IndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public υ1IndexElement(
           PositiveInt value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the service level.
        /// </summary>
        public PositiveInt Value { get; }
    }
}
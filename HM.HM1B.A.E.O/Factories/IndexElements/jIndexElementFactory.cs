﻿namespace HM.HM1B.A.E.O.Factories.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Classes.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.InterfacesFactories.IndexElements;

    internal sealed class jIndexElementFactory : IjIndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jIndexElementFactory()
        {
        }

        public IjIndexElement Create(
            Organization value)
        {
            IjIndexElement indexElement = null;

            try
            {
                indexElement = new jIndexElement(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return indexElement;
        }
    }
}
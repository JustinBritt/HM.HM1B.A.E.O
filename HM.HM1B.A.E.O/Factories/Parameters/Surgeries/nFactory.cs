﻿namespace HM.HM1B.A.E.O.Factories.Parameters.Surgeries
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Classes.Parameters.Surgeries;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.Surgeries;
    using HM.HM1B.A.E.O.Interfaces.Parameters.Surgeries;
    using HM.HM1B.A.E.O.InterfacesFactories.Parameters.Surgeries;

    internal sealed class nFactory : InFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public nFactory()
        {
        }

        public In Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, InParameterElement>> value)
        {
            In parameter = null;

            try
            {
                parameter = new n(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}
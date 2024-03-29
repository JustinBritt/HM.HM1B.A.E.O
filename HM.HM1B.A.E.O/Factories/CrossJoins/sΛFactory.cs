﻿namespace HM.HM1B.A.E.O.Factories.CrossJoins
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM1B.A.E.O.Classes.CrossJoins;
    using HM.HM1B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM1B.A.E.O.Interfaces.CrossJoins;
    using HM.HM1B.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class sΛFactory : IsΛFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sΛFactory()
        {
        }

        public IsΛ Create(
            ImmutableList<IsΛCrossJoinElement> value)
        {
            IsΛ crossJoin = null;

            try
            {
                crossJoin = new sΛ(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return crossJoin;
        }
    }
}
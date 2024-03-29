﻿namespace HM.HM1B.A.E.O.Classes.CrossJoins
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM1B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM1B.A.E.O.Interfaces.CrossJoins;

    internal sealed class sΛ : IsΛ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sΛ(
            ImmutableList<IsΛCrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IsΛCrossJoinElement> Value { get; }
    }
}
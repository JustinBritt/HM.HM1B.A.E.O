﻿namespace HM.HM1B.A.E.O.InterfacesFactories.Indices
{
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;

    public interface ItFactory
    {
        It Create(
            ImmutableList<ItIndexElement> value);
    }
}
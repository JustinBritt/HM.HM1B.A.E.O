﻿namespace HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;

    public interface IΔParameterElementFactory
    {
        IΔParameterElement Create(
            IjIndexElement jIndexElement,
            ImmutableList<IsIndexElement> value);
    }
}
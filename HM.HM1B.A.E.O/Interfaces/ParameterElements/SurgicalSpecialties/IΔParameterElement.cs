namespace HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties
{
    using System;
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;

    public interface IΔParameterElement : IComparable<IΔParameterElement>
    {
        IjIndexElement jIndexElement { get; }

        ImmutableList<IsIndexElement> Value { get; }
    }
}
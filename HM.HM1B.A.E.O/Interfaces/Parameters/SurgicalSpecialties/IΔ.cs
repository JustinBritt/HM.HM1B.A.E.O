namespace HM.HM1B.A.E.O.Interfaces.Parameters.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;

    public interface IΔ
    {
        ImmutableList<IΔParameterElement> Value { get; }
    }
}
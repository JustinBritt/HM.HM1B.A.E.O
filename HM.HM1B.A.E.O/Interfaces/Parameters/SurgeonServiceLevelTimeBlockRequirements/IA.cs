namespace HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonServiceLevelTimeBlockRequirements
{
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;

    public interface IA
    {
        ImmutableList<IAParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            Iυ1IndexElement υ1IndexElement);
    }
}
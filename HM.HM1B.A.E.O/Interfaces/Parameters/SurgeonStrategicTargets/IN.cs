namespace HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonStrategicTargets
{
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonStrategicTargets;

    public interface IN
    {
        ImmutableList<INParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement);
    }
}
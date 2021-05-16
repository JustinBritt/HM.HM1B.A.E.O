namespace HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonPenaltyWeights
{
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonPenaltyWeights;

    public interface Iω
    {
        ImmutableList<IωParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement);
    }
}
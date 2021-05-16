namespace HM.HM1B.A.E.O.InterfacesFactories.Parameters.SurgeonPenaltyWeights
{
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonPenaltyWeights;

    public interface IωFactory
    {
        Iω Create(
            ImmutableList<IωParameterElement> value);
    }
}
namespace HM.HM1B.A.E.O.InterfacesFactories.Parameters.ScenarioProbabilities
{
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;
    using HM.HM1B.A.E.O.Interfaces.Parameters.ScenarioProbabilities;

    public interface IΡFactory
    {
        IΡ Create(
            ImmutableList<IΡParameterElement> value);
    }
}
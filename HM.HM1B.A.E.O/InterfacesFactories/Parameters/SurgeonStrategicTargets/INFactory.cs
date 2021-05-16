namespace HM.HM1B.A.E.O.InterfacesFactories.Parameters.SurgeonStrategicTargets
{
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonStrategicTargets;

    public interface INFactory
    {
        IN Create(
            ImmutableList<INParameterElement> value);
    }
}
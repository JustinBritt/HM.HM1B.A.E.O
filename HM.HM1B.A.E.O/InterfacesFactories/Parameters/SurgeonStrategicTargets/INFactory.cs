namespace HM.HM1B.A.E.O.InterfacesFactories.Parameters.SurgeonStrategicTargets
{
    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonStrategicTargets;

    public interface INFactory
    {
        IN Create(
            RedBlackTree<IsIndexElement, INParameterElement> value);
    }
}
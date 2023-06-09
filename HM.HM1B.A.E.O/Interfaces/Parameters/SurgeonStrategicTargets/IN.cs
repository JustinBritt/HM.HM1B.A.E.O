namespace HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonStrategicTargets
{
    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonStrategicTargets;

    public interface IN
    {
        RedBlackTree<IsIndexElement, INParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement);
    }
}
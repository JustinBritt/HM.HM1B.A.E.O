namespace HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonPenaltyWeights
{
    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonPenaltyWeights;

    public interface Iω
    {
        RedBlackTree<IsIndexElement, IωParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement);
    }
}
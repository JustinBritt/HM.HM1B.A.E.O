namespace HM.HM1B.A.E.O.InterfacesFactories.Parameters.SurgeonPenaltyWeights
{
    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonPenaltyWeights;

    public interface IωFactory
    {
        Iω Create(
            RedBlackTree<IsIndexElement, IωParameterElement> value);
    }
}
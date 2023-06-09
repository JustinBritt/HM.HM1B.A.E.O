namespace HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonServiceLevelTimeBlockRequirements
{
    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;

    public interface IA
    {
        RedBlackTree<IsIndexElement, RedBlackTree<Iυ1IndexElement, IAParameterElement>> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            Iυ1IndexElement υ1IndexElement);
    }
}
namespace HM.HM1B.A.E.O.InterfacesFactories.Parameters.SurgeonServiceLevelTimeBlockRequirements
{
    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonServiceLevelTimeBlockRequirements;

    public interface IAFactory
    {
        IA Create(
            RedBlackTree<IsIndexElement, RedBlackTree<Iυ1IndexElement, IAParameterElement>> value);
    }
}
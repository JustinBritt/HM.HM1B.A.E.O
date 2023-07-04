namespace HM.HM1B.A.E.O.InterfacesFactories.Indices
{
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.Comparers;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;

    public interface IrFactory
    {
        Ir Create(
            IRedBlackTreeFactory redBlackTreeFactory,
            ILocationComparer locationComparer,
            ImmutableList<IrIndexElement> value);
    }
}
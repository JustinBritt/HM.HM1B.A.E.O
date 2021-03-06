namespace HM.HM1B.A.E.O.InterfacesFactories.Indices
{
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;

    public interface Iυ1Factory
    {
        Iυ1 Create(
            ImmutableList<Iυ1IndexElement> value);
    }
}
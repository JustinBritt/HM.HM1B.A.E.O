namespace HM.HM1B.A.E.O.InterfacesFactories.CrossJoins
{
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM1B.A.E.O.Interfaces.CrossJoins;

    public interface IsΛFactory
    {
        IsΛ Create(
            ImmutableList<IsΛCrossJoinElement> value);
    }
}
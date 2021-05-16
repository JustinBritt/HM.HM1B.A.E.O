namespace HM.HM1B.A.E.O.Interfaces.CrossJoins
{
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.CrossJoinElements;

    public interface IsΛ
    {
        ImmutableList<IsΛCrossJoinElement> Value { get; }
    }
}
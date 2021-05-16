namespace HM.HM1B.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM1B.A.E.O.Interfaces.IndexElements;

    public interface IsΛCrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        IΛIndexElement ΛIndexElement { get; }
    }
}
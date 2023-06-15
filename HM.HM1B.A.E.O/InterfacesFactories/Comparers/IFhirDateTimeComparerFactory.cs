namespace HM.HM1B.A.E.O.InterfacesFactories.Comparers
{
    using HM.HM1B.A.E.O.Interfaces.Comparers;

    public interface IFhirDateTimeComparerFactory
    {
        IFhirDateTimeComparer Create();
    }
}
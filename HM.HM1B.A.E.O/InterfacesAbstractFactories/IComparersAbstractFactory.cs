namespace HM.HM1B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM1B.A.E.O.InterfacesFactories.Comparers;

    public interface IComparersAbstractFactory
    {
        ILocationComparerFactory CreateLocationComparerFactory();

        IOrganizationComparerFactory CreateOrganizationComparerFactory();
    }
}
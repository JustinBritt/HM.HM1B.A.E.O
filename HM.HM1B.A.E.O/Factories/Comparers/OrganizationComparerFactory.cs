namespace HM.HM1B.A.E.O.Factories.Comparers
{
    using HM.HM1B.A.E.O.Classes.Comparers;
    using HM.HM1B.A.E.O.Interfaces.Comparers;
    using HM.HM1B.A.E.O.InterfacesFactories.Comparers;

    internal sealed class OrganizationComparerFactory : IOrganizationComparerFactory
    {
        public OrganizationComparerFactory()
        {
        }

        public IOrganizationComparer Create()
        {
            IOrganizationComparer instance = null;

            try
            {
                instance = new OrganizationComparer();
            }
            finally
            {
            }

            return instance;
        }
    }
}
namespace HM.HM1B.A.E.O.Factories.Comparers
{
    using HM.HM1B.A.E.O.Classes.Comparers;
    using HM.HM1B.A.E.O.Interfaces.Comparers;
    using HM.HM1B.A.E.O.InterfacesFactories.Comparers;

    internal sealed class LocationComparerFactory : ILocationComparerFactory
    {
        public LocationComparerFactory()
        {
        }

        public ILocationComparer Create()
        {
            ILocationComparer instance = null;

            try
            {
                instance = new LocationComparer();
            }
            finally
            {
            }

            return instance;
        }
    }
}
namespace HM.HM1B.A.E.O.InterfacesFactories.Configurations
{
    using OPTANO.Modeling.Optimization.Configuration;

    using HM.HM1B.A.E.O.Interfaces.Configurations;

    public interface IHM1BConfigurationFactory
    {
        IHM1BConfiguration Create(
            Configuration configuration);
    }
}
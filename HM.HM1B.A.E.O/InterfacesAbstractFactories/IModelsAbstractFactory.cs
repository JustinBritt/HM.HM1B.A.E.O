namespace HM.HM1B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM1B.A.E.O.InterfacesFactories.Models;

    public interface IModelsAbstractFactory
    {
        IHM1BModelFactory CreateHM1BModelFactory();
    }
}
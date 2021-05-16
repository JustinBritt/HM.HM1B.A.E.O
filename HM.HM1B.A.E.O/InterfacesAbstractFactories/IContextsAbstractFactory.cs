namespace HM.HM1B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM1B.A.E.O.InterfacesFactories.Contexts;

    public interface IContextsAbstractFactory
    {
        IHM1BInputContextFactory CreateHM1BInputContextFactory();

        IHM1BOutputContextFactory CreateHM1BOutputContextFactory();
    }
}
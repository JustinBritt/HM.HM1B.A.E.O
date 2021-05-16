namespace HM.HM1B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM1B.A.E.O.InterfacesFactories.Exports;

    public interface IExportsAbstractFactory
    {
        IHM1BExportFactory CreateHM1BExportFactory();
    }
}
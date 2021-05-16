namespace HM.HM1B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM1B.A.E.O.InterfacesFactories.IndexElements;

    public interface IIndexElementsAbstractFactory
    {
        IjIndexElementFactory CreatejIndexElementFactory();

        IrIndexElementFactory CreaterIndexElementFactory();

        IsIndexElementFactory CreatesIndexElementFactory();

        ItIndexElementFactory CreatetIndexElementFactory();

        IΛIndexElementFactory CreateΛIndexElementFactory();

        Iυ1IndexElementFactory Createυ1IndexElementFactory();
    }
}
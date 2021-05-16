namespace HM.HM1B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM1B.A.E.O.InterfacesFactories.Variables;

    public interface IVariablesAbstractFactory
    {
        IBFactory CreateBFactory();

        Ie1MinusFactory Createe1MinusFactory();

        Ie1PlusFactory Createe1PlusFactory();
    }
}
namespace HM.HM1B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM1B.A.E.O.InterfacesFactories.Constraints;

    public interface IConstraintsAbstractFactory
    {
        IConstraints1LFactory CreateConstraints1LFactory();

        IConstraints1UFactory CreateConstraints1UFactory();

        IConstraint2Factory CreateConstraint2Factory();

        IConstraints3Factory CreateConstraints3Factory();
    }
}
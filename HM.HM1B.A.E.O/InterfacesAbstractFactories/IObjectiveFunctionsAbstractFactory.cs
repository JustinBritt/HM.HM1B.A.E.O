namespace HM.HM1B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM1B.A.E.O.InterfacesFactories.ObjectiveFunctions;

    public interface IObjectiveFunctionsAbstractFactory
    {
        IObjectiveFunction100Factory CreateObjectiveFunction100Factory();

        IObjectiveFunction110Factory CreateObjectiveFunction110Factory();

        IObjectiveFunction111Factory CreateObjectiveFunction111Factory();
    }
}
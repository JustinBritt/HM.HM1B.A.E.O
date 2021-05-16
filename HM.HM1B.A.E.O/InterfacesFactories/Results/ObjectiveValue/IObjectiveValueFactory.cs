namespace HM.HM1B.A.E.O.InterfacesFactories.Results.ObjectiveValue
{
    using HM.HM1B.A.E.O.Interfaces.Results.ObjectiveValue;

    public interface IObjectiveValueFactory
    {
        IObjectiveValue Create(
            decimal value);
    }
}
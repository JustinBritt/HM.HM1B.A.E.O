namespace HM.HM1B.A.E.O.InterfacesFactories.Results.BestBound
{
    using HM.HM1B.A.E.O.Interfaces.Results.BestBound;

    public interface IBestBoundFactory
    {
        IBestBound Create(
            decimal value);
    }
}
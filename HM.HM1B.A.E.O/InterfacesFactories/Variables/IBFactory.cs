namespace HM.HM1B.A.E.O.InterfacesFactories.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Variables;

    public interface IBFactory
    {
        IB Create(
            VariableCollection<IsIndexElement> value);
    }
}
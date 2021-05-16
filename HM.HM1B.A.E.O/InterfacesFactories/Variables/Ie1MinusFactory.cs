namespace HM.HM1B.A.E.O.InterfacesFactories.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Variables;

    public interface Ie1MinusFactory
    {
        Ie1Minus Create(
            VariableCollection<IsIndexElement, IΛIndexElement> value);
    }
}
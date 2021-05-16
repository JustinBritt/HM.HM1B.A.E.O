namespace HM.HM1B.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;

    public interface Ie1Plus
    {
        VariableCollection<IsIndexElement, IΛIndexElement> Value { get; }
    }
}
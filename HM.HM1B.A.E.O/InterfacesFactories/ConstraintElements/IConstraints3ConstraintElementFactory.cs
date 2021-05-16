namespace HM.HM1B.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM1B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.Interfaces.Parameters.Surgeries;
    using HM.HM1B.A.E.O.Interfaces.Variables;

    public interface IConstraints3ConstraintElementFactory
    {
        IConstraints3ConstraintElement Create(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            IN N,
            In n,
            IB B,
            Ie1Minus e1Minus,
            Ie1Plus e1Plus);
    }
}
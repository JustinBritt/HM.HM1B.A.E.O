namespace HM.HM1B.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM1B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.Interfaces.Variables;

    public interface IConstraints1UConstraintElementFactory
    {
        IConstraints1UConstraintElement Create(
            IsIndexElement sIndexElement,
            Iυ1IndexElement υ1StarPlus1,
            IA A,
            IB B);
    }
}
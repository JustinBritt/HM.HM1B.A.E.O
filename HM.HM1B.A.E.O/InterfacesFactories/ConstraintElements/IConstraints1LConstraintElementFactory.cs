namespace HM.HM1B.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM1B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.Interfaces.Variables;

    public interface IConstraints1LConstraintElementFactory
    {
        IConstraints1LConstraintElement Create(
            IsIndexElement sIndexElement,
            Iυ1IndexElement υ1Star,
            IA A,
            IB B);
    }
}
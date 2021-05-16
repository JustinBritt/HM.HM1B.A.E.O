namespace HM.HM1B.A.E.O.InterfacesFactories.Constraints
{
    using HM.HM1B.A.E.O.Interfaces.Constraints;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.Interfaces.Parameters.DayAvailabilities;
    using HM.HM1B.A.E.O.Interfaces.Variables;

    public interface IConstraint2Factory
    {
        IConstraint2 Create(
            Ir r,
            Is s,
            It t,
            Iψ ψ,
            IB B);
    }
}
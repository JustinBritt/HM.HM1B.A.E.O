namespace HM.HM1B.A.E.O.InterfacesFactories.Constraints
{
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM1B.A.E.O.Interfaces.Constraints;

    public interface IConstraints1LFactory
    {
        IConstraints1L Create(
            ImmutableList<IConstraints1LConstraintElement> value);
    }
}
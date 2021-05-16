namespace HM.HM1B.A.E.O.InterfacesFactories.Constraints
{
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM1B.A.E.O.Interfaces.Constraints;

    public interface IConstraints1UFactory
    {
        IConstraints1U Create(
            ImmutableList<IConstraints1UConstraintElement> value);
    }
}
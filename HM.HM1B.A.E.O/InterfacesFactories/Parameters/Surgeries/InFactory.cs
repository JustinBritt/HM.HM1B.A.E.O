namespace HM.HM1B.A.E.O.InterfacesFactories.Parameters.Surgeries
{
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.ParameterElements.Surgeries;
    using HM.HM1B.A.E.O.Interfaces.Parameters.Surgeries;

    public interface InFactory
    {
        In Create(
            ImmutableList<InParameterElement> value);
    }
}
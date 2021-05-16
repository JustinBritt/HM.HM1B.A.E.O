namespace HM.HM1B.A.E.O.InterfacesFactories.Parameters.SurgeonServiceLevelTimeBlockRequirements
{
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonServiceLevelTimeBlockRequirements;

    public interface IAFactory
    {
        IA Create(
            ImmutableList<IAParameterElement> value);
    }
}
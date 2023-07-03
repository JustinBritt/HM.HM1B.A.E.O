namespace HM.HM1B.A.E.O.InterfacesFactories.Contexts
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;

    public interface ISurgicalSpecialtiesVisitorFactory
    {
        ISurgicalSpecialtiesVisitor<TKey, TValue> Create<TKey, TValue>(
            IΔParameterElementFactory ΔParameterElementFactory,
            Ij j,
            Is s)
            where TKey : Organization
            where TValue : IImmutableSet<Organization>;
    }
}
namespace HM.HM1B.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;

    public interface Iυ1
    {
        ImmutableList<Iυ1IndexElement> Value { get; }

        Iυ1IndexElement GetElementAt(
            PositiveInt value);
    }
}
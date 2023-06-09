namespace HM.HM1B.A.E.O.Interfaces.IndexElements
{
    using System;

    using Hl7.Fhir.Model;

    public interface Iυ1IndexElement : IComparable<Iυ1IndexElement>
    {
        /// <summary>
        /// Gets the service level.
        /// </summary>
        INullableValue<int> Value { get; }
    }
}
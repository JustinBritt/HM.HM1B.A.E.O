namespace HM.HM1B.A.E.O.Interfaces.IndexElements
{
    using Hl7.Fhir.Model;

    public interface IjIndexElement
    {
        /// <summary>
        /// Gets the surgical specialty.
        /// </summary>
        Organization Value { get; }
    }
}
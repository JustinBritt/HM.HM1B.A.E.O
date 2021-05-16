namespace HM.HM1B.A.E.O.Interfaces.Models
{
    using OPTANO.Modeling.Optimization;

    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM1B.A.E.O.Interfaces.Variables;

    public interface IHM1BModel
    {
        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        Model Model { get; }

        Ij j { get; }

        Is s { get; }

        IΔ Δ { get; }

        IB B { get; }
    }
}
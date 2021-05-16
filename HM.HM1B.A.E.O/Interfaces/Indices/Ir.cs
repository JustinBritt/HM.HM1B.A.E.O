namespace HM.HM1B.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;

    public interface Ir
    {
        ImmutableList<IrIndexElement> Value { get; }

        int GetR();
    }
}
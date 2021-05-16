namespace HM.HM1B.A.E.O.Classes.Indices
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;

    internal sealed class r : Ir
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public r(
            ImmutableList<IrIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IrIndexElement> Value { get; }

        public int GetR()
        {
            return this.Value
                .Distinct()
                .Count();
        }
    }
}
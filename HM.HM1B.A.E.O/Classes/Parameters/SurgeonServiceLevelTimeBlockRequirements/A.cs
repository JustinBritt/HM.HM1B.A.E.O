namespace HM.HM1B.A.E.O.Classes.Parameters.SurgeonServiceLevelTimeBlockRequirements
{
    using System.Collections.Immutable;
    using System.Linq;
 
    using log4net;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonServiceLevelTimeBlockRequirements;

    internal sealed class A : IA
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public A(
            ImmutableList<IAParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IAParameterElement> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            Iυ1IndexElement υ1IndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.υ1IndexElement == υ1IndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}
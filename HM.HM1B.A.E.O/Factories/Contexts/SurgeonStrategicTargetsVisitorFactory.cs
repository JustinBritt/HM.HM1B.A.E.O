namespace HM.HM1B.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.Contexts;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;
    using HM.HM1B.A.E.O.Visitors.Contexts;

    internal sealed class SurgeonStrategicTargetsVisitorFactory : ISurgeonStrategicTargetsVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonStrategicTargetsVisitorFactory()
        {
        }

        public ISurgeonStrategicTargetsVisitor<TKey, TValue> Create<TKey, TValue>(
            INParameterElementFactory NParameterElementFactory,
            Is s)
            where TKey : Organization
            where TValue : INullableValue<int>
        {
            ISurgeonStrategicTargetsVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new SurgeonStrategicTargetsVisitor<TKey, TValue>(
                    NParameterElementFactory,
                    s);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}
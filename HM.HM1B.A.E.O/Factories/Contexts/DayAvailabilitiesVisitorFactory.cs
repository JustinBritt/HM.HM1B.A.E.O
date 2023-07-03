namespace HM.HM1B.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.Contexts;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.DayAvailabilities;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;
    using HM.HM1B.A.E.O.Visitors.Contexts;

    internal sealed class DayAvailabilitiesVisitorFactory : IDayAvailabilitiesVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayAvailabilitiesVisitorFactory()
        {
        }

        public IDayAvailabilitiesVisitor<TKey, TValue> Create<TKey, TValue>(
            IψParameterElementFactory ψParameterElementFactory,
            It t)
            where TKey : FhirDateTime
            where TValue : INullableValue<bool>
        {
            IDayAvailabilitiesVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new DayAvailabilitiesVisitor<TKey, TValue>(
                    ψParameterElementFactory,
                    t);
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
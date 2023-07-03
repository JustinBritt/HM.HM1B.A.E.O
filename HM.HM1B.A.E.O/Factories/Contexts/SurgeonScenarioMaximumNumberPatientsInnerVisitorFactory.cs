namespace HM.HM1B.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.Contexts;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.Surgeries;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;
    using HM.HM1B.A.E.O.Visitors.Contexts;

    internal sealed class SurgeonScenarioMaximumNumberPatientsInnerVisitorFactory : ISurgeonScenarioMaximumNumberPatientsInnerVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioMaximumNumberPatientsInnerVisitorFactory()
        {
        }

        public ISurgeonScenarioMaximumNumberPatientsInnerVisitor<TKey, TValue> Create<TKey, TValue>(
            InParameterElementFactory nParameterElementFactory,
            IsIndexElement sIndexElement,
            IΛ Λ)
            where TKey : INullableValue<int>
            where TValue : INullableValue<int>
        {
            ISurgeonScenarioMaximumNumberPatientsInnerVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new SurgeonScenarioMaximumNumberPatientsInnerVisitor<TKey, TValue>(
                    nParameterElementFactory,
                    sIndexElement,
                    Λ);
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
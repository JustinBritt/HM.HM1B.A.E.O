namespace HM.HM1B.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.Contexts;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.Surgeries;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;
    using HM.HM1B.A.E.O.Visitors.Contexts;
   
    internal sealed class SurgeonScenarioMaximumNumberPatientsOuterVisitorFactory : ISurgeonScenarioMaximumNumberPatientsOuterVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioMaximumNumberPatientsOuterVisitorFactory()
        {
        }

        public ISurgeonScenarioMaximumNumberPatientsOuterVisitor<TKey, TValue> Create<TKey, TValue>(
            InParameterElementFactory nParameterElementFactory,
            Is s,
            IΛ Λ)
            where TKey : Organization
            where TValue : RedBlackTree<INullableValue<int>, INullableValue<int>>
        {
            ISurgeonScenarioMaximumNumberPatientsOuterVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new SurgeonScenarioMaximumNumberPatientsOuterVisitor<TKey, TValue>(
                    nParameterElementFactory,
                    s,
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
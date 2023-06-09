namespace HM.HM1B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.Surgeries;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.Surgeries;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonScenarioMaximumNumberPatientsInnerVisitor<TKey, TValue> : ISurgeonScenarioMaximumNumberPatientsInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioMaximumNumberPatientsInnerVisitor(
            InParameterElementFactory nParameterElementFactory,
            IsIndexElement sIndexElement,
            IΛ Λ)
        {
            this.nParameterElementFactory = nParameterElementFactory;

            this.sIndexElement = sIndexElement;

            this.Λ = Λ;

            this.RedBlackTree = new RedBlackTree<IΛIndexElement, InParameterElement>();
        }

        private InParameterElementFactory nParameterElementFactory { get; }

        private IsIndexElement sIndexElement { get; }

        private IΛ Λ { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IΛIndexElement, InParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IΛIndexElement ΛIndexElement = this.Λ.Value.Where(w => w.Value.Value.Value == obj.Key.Value.Value).SingleOrDefault();

            this.RedBlackTree.Add(
                ΛIndexElement,
                this.nParameterElementFactory.Create(
                    this.sIndexElement,
                    ΛIndexElement,
                    obj.Value));
        }
    }
}
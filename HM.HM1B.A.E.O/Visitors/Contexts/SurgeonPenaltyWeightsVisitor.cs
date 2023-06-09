namespace HM.HM1B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonPenaltyWeightsVisitor<TKey, TValue> : ISurgeonPenaltyWeightsVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : INullableValue<decimal>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonPenaltyWeightsVisitor(
            IωParameterElementFactory ωParameterElementFactory,
            Is s)
        {
            this.ωParameterElementFactory = ωParameterElementFactory;

            this.s = s;

            this.RedBlackTree = new RedBlackTree<IsIndexElement, IωParameterElement>();
        }

        private IωParameterElementFactory ωParameterElementFactory { get; }

        private Is s { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, IωParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.Value[obj.Key];

            this.RedBlackTree.Add(
                sIndexElement,
                this.ωParameterElementFactory.Create(
                    sIndexElement,
                    obj.Value));
        }
    }
}
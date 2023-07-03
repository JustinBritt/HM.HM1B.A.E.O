namespace HM.HM1B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonServiceLevelNumberTimeBlocksInnerVisitor<TKey, TValue> : ISurgeonServiceLevelNumberTimeBlocksInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonServiceLevelNumberTimeBlocksInnerVisitor(
            IRedBlackTreeFactory redBlackTreeFactory,
            IAParameterElementFactory AParameterElementFactory,
            IsIndexElement sIndexElement,
            Iυ1 υ1)
        {
            this.AParameterElementFactory = AParameterElementFactory;

            this.sIndexElement = sIndexElement;

            this.υ1 = υ1;

            this.RedBlackTree = redBlackTreeFactory.Create<Iυ1IndexElement, IAParameterElement>();
        }

        private IAParameterElementFactory AParameterElementFactory { get; }

        private IsIndexElement sIndexElement { get; }

        private Iυ1 υ1 { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Iυ1IndexElement, IAParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            Iυ1IndexElement υ1IndexElement = this.υ1.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                υ1IndexElement,
                this.AParameterElementFactory.Create(
                    this.sIndexElement,
                    υ1IndexElement,
                    obj.Value));
        }
    }
}
﻿namespace HM.HM1B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;
    using HM.HM1B.A.E.O.InterfacesFactories.Contexts;
    using HM.HM1B.A.E.O.InterfacesFactories.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;

    internal sealed class SurgeonServiceLevelNumberTimeBlocksOuterVisitor<TKey, TValue> : ISurgeonServiceLevelNumberTimeBlocksOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<int>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonServiceLevelNumberTimeBlocksOuterVisitor(
            ISurgeonServiceLevelNumberTimeBlocksInnerVisitorFactory surgeonServiceLevelNumberTimeBlocksInnerVisitorFactory,
            IAParameterElementFactory AParameterElementFactory,
            Is s,
            Iυ1 υ1)
        {
            this.SurgeonServiceLevelNumberTimeBlocksInnerVisitorFactory = surgeonServiceLevelNumberTimeBlocksInnerVisitorFactory;

            this.AParameterElementFactory = AParameterElementFactory;

            this.s = s;

            this.υ1 = υ1;

            this.RedBlackTree = new RedBlackTree<IsIndexElement, RedBlackTree<Iυ1IndexElement, IAParameterElement>>();
        }

        private ISurgeonServiceLevelNumberTimeBlocksInnerVisitorFactory SurgeonServiceLevelNumberTimeBlocksInnerVisitorFactory { get; }

        private IAParameterElementFactory AParameterElementFactory { get; }

        private Is s { get; }

        private Iυ1 υ1 { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, RedBlackTree<Iυ1IndexElement, IAParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.Value[obj.Key];

            RedBlackTree<INullableValue<int>, INullableValue<int>> value = obj.Value;

            var innerVisitor = this.SurgeonServiceLevelNumberTimeBlocksInnerVisitorFactory.Create<INullableValue<int>, INullableValue<int>>(
                this.AParameterElementFactory,
                sIndexElement,
                this.υ1);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                sIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}
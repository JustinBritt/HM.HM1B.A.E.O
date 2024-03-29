﻿namespace HM.HM1B.A.E.O.Classes.Parameters.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgicalSpecialties;

    internal sealed class Δ : IΔ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Δ(
            RedBlackTree<IjIndexElement, ImmutableList<IsIndexElement>> redBlackTree,
            ImmutableList<IΔParameterElement> value)
        {
            this.RedBlackTree = redBlackTree;

            this.Value = value;
        }

        private RedBlackTree<IjIndexElement, ImmutableList<IsIndexElement>> RedBlackTree { get; }

        public ImmutableList<IΔParameterElement> Value { get; }
    }
}
﻿namespace HM.HM1B.A.E.O.Classes.ParameterElements.SurgicalSpecialties
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;

    internal sealed class ΔParameterElement : IΔParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΔParameterElement(
            IjIndexElement jIndexElement,
            ImmutableList<IsIndexElement> value)
        {
            this.jIndexElement = jIndexElement;

            this.Value = value;
        }

        public IjIndexElement jIndexElement { get; }

        public ImmutableList<IsIndexElement> Value { get; }

        /// <inheritdoc/>
        public int CompareTo(
            IΔParameterElement other)
        {
            return String.CompareOrdinal(
                other.jIndexElement.Value.Id,
                this.jIndexElement.Value.Id);
        }
    }
}
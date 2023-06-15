namespace HM.HM1B.A.E.O.Factories.Indices
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Classes.Indices;
    using HM.HM1B.A.E.O.Interfaces.Comparers;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.Indices;
    
    internal sealed class tFactory : ItFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public tFactory()
        {
        }

        public It Create(
            IFhirDateTimeComparer FhirDateTimeComparer,
            ImmutableList<ItIndexElement> value)
        {
            It index = null;

            try
            {
                index = new t(
                    this.CreateRedBlackTree(
                        FhirDateTimeComparer,
                        value));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return index;
        }

        private RedBlackTree<FhirDateTime, ItIndexElement> CreateRedBlackTree(
            IFhirDateTimeComparer FhirDateTimeComparer,
            ImmutableList<ItIndexElement> value)
        {
            RedBlackTree<FhirDateTime, ItIndexElement> redBlackTree = new RedBlackTree<FhirDateTime, ItIndexElement>(
                FhirDateTimeComparer);

            foreach (ItIndexElement tIndexElement in value)
            {
                redBlackTree.Add(
                    tIndexElement.Value,
                    tIndexElement);
            }

            return redBlackTree;
        }
    }
}
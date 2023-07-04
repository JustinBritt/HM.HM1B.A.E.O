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
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;

    internal sealed class jFactory : IjFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jFactory()
        {
        }

        public Ij Create(
            IRedBlackTreeFactory redBlackTreeFactory,
            IOrganizationComparer organizationComparer,
            ImmutableList<IjIndexElement> value)
        {
            Ij index = null;

            try
            {
                index = new j(
                    this.CreateRedBlackTree(
                        redBlackTreeFactory,
                        organizationComparer,
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

        private RedBlackTree<Organization, IjIndexElement> CreateRedBlackTree(
            IRedBlackTreeFactory redBlackTreeFactory,
            IOrganizationComparer organizationComparer,
            ImmutableList<IjIndexElement> value)
        {
            RedBlackTree<Organization, IjIndexElement> redBlackTree = redBlackTreeFactory.Create<Organization, IjIndexElement>(
                organizationComparer);

            foreach (IjIndexElement jIndexElement in value)
            {
                redBlackTree.Add(
                    jIndexElement.Value,
                    jIndexElement);
            }

            return redBlackTree;
        }
    }
}
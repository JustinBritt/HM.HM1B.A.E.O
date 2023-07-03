namespace HM.HM1B.A.E.O.Visitors.Results.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.Comparers;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM1B.A.E.O.InterfacesVisitors.Results.SurgicalSpecialtyNumberAssignedTimeBlocks;

    internal sealed class BVisitor<TKey, TValue> : IBVisitor<TKey, TValue>
        where TKey : IjIndexElement
        where TValue : IBResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BVisitor(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IOrganizationComparer organizationComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.RedBlackTree = redBlackTreeFactory.Create<Organization, INullableValue<int>>(
                organizationComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Organization, INullableValue<int>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            this.RedBlackTree.Add(
                obj.Key.Value,
                this.NullableValueFactory.Create<int>(
                    obj.Value.Value));
        }
    }
}
namespace HM.HM1B.A.E.O.Classes.Results.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class B : IB
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public B(
            ImmutableList<IBResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IBResultElement> Value { get; }

        public RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<Organization, INullableValue<int>> redBlackTree = new RedBlackTree<Organization, INullableValue<int>>(
                new HM.HM1B.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (IBResultElement BResultElement in this.Value)
            {
                redBlackTree.Add(
                    BResultElement.jIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        BResultElement.Value));
            }

            return redBlackTree;
        }
    }
}
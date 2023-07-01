namespace HM.HM1B.A.E.O.Classes.Results.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Comparers;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class B : IB
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public B(
            RedBlackTree<IΔParameterElement, IBResultElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IΔParameterElement, IBResultElement> Value { get; }

        public RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            IOrganizationComparerFactory organizationComparerFactory,
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<Organization, INullableValue<int>> redBlackTree = new RedBlackTree<Organization, INullableValue<int>>(
                organizationComparerFactory.Create());

            foreach (IBResultElement BResultElement in this.Value.Values)
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
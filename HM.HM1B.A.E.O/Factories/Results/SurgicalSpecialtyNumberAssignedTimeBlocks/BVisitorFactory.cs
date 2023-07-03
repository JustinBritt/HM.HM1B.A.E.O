namespace HM.HM1B.A.E.O.Factories.Results.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Interfaces.Comparers;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM1B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesVisitors.Results.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Visitors.Results.SurgicalSpecialtyNumberAssignedTimeBlocks;

    internal sealed class BVisitorFactory : IBVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BVisitorFactory()
        {
        }

        public IBVisitor<TKey, TValue> Create<TKey, TValue>(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IOrganizationComparer organizationComparer)
            where TKey : IΔParameterElement
            where TValue : IBResultElement
        {
            IBVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new BVisitor<TKey, TValue>(
                    nullableValueFactory,
                    redBlackTreeFactory,
                    organizationComparer);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}
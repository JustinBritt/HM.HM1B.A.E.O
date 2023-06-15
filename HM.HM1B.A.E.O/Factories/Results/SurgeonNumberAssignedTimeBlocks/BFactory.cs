namespace HM.HM1B.A.E.O.Factories.Results.SurgeonNumberAssignedTimeBlocks
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Classes.Results.SurgeonNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.Results.SurgeonNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedTimeBlocks;

    internal sealed class BFactory : IBFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BFactory()
        {
        }

        public IB Create(
            RedBlackTree<IsIndexElement, IBResultElement> value)
        {
            IB result = null;

            try
            {
                result = new B(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}
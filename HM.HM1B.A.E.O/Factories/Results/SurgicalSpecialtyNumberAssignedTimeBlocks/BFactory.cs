namespace HM.HM1B.A.E.O.Factories.Results.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Classes.Results.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedTimeBlocks;

    internal sealed class BFactory : IBFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BFactory()
        {
        }

        public IB Create(
            RedBlackTree<IΔParameterElement, IBResultElement> value)
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
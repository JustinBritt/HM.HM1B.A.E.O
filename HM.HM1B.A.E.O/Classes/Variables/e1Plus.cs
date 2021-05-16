namespace HM.HM1B.A.E.O.Classes.Variables
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Variables;

    internal sealed class e1Plus : Ie1Plus
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public e1Plus(
            VariableCollection<IsIndexElement, IΛIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IsIndexElement, IΛIndexElement> Value { get; }
    }
}
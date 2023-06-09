namespace HM.HM1B.A.E.O.Classes.Parameters.SurgeonServiceLevelTimeBlockRequirements
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonServiceLevelTimeBlockRequirements;

    internal sealed class A : IA
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public A(
            RedBlackTree<IsIndexElement, RedBlackTree<Iυ1IndexElement, IAParameterElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<Iυ1IndexElement, IAParameterElement>> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            Iυ1IndexElement υ1IndexElement)
        {
            return this.Value[sIndexElement][υ1IndexElement].Value.Value.Value;
        }
    }
}
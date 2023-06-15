namespace HM.HM1B.A.E.O.Classes.Indices
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;

    internal sealed class υ1 : Iυ1
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public υ1(
            RedBlackTree<INullableValue<int>, Iυ1IndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<INullableValue<int>, Iυ1IndexElement> Value { get; }

        public Iυ1IndexElement GetElementAt(
            INullableValue<int> value)
        {
            return this.Value[value];
        }
    }
}
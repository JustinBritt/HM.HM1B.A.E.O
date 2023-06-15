namespace HM.HM1B.A.E.O.InterfacesVisitors.Results.SurgeonNumberAssignedTimeBlocks
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedTimeBlocks;

    public interface IBVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : IsIndexElement
        where TValue : IBResultElement
    {
        RedBlackTree<Organization, INullableValue<int>> RedBlackTree { get; }
    }
}
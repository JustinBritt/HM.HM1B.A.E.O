namespace HM.HM1B.A.E.O.InterfacesVisitors.Results.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM1B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM1B.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedTimeBlocks;

    public interface IBVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : IΔParameterElement
        where TValue : IBResultElement
    {
        RedBlackTree<Organization, INullableValue<int>> RedBlackTree { get; }
    }
}
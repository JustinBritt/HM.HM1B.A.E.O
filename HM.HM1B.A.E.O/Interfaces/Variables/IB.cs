namespace HM.HM1B.A.E.O.Interfaces.Variables
{
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using OPTANO.Modeling.Optimization;

    using HM.HM1B.A.E.O.Interfaces.IndexElements;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM1B.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedTimeBlocks;

    public interface IB
    {
        VariableCollection<IsIndexElement> Value { get; }

        int GetElementAt(
            IsIndexElement sIndexElement);

        ImmutableList<KeyValuePair<Organization, int>> GetElementsAt(
            ImmutableList<IsIndexElement> sIndexElements);

        Interfaces.Results.SurgeonNumberAssignedTimeBlocks.IB GetElementsAt(
            IBResultElementFactory BResultElementFactory,
            IBFactory BFactory,
            Is s);
    }
}
namespace HM.HM1B.A.E.O.Classes.Models
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using HM.HM1B.A.E.O.InterfacesAbstractFactories;
    using HM.HM1B.A.E.O.Interfaces.Contexts;
    using HM.HM1B.A.E.O.Interfaces.CrossJoins;
    using HM.HM1B.A.E.O.Interfaces.Indices;
    using HM.HM1B.A.E.O.Interfaces.Parameters.DayAvailabilities;
    using HM.HM1B.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using HM.HM1B.A.E.O.Interfaces.Parameters.ServiceLevelAssignments;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonPenaltyWeights;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonServiceLevelTimeBlockRequirements;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgeonStrategicTargets;
    using HM.HM1B.A.E.O.Interfaces.Parameters.Surgeries;
    using HM.HM1B.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM1B.A.E.O.Interfaces.Variables;
    using HM.HM1B.A.E.O.InterfacesVisitors.Contexts;
    
    internal abstract class HM1BModel
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM1BModel(
            IComparersAbstractFactory comparersAbstractFactory,
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory, 
            IContextsAbstractFactory contextsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IIndicesAbstractFactory indicesAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IParametersAbstractFactory parametersAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IHM1BInputContext HM1BInputContext)
        {
            this.Context = HM1BInputContext;

            this.Model = dependenciesAbstractFactory.CreateModelFactory().Create();

            // Indices

            // j
            this.j = indicesAbstractFactory.CreatejFactory().Create(
                comparersAbstractFactory.CreateOrganizationComparerFactory().Create(),
                this.Context.SurgicalSpecialties
                .Select(x => x.Key)
                .Select(x => indexElementsAbstractFactory.CreatejIndexElementFactory().Create(x))
                .ToImmutableList());

            // r
            this.r = indicesAbstractFactory.CreaterFactory().Create(
                comparersAbstractFactory.CreateLocationComparerFactory().Create(),
                this.Context.OperatingRooms
                .Entry
                .Where(x => x.Resource is Location)
                .Select(x => indexElementsAbstractFactory.CreaterIndexElementFactory().Create((Location)x.Resource))
                .ToImmutableList());

            // s
            this.s = indicesAbstractFactory.CreatesFactory().Create(
                comparersAbstractFactory.CreateOrganizationComparerFactory().Create(),
                this.Context.Surgeons
                .Entry
                .Where(x => x.Resource is Organization)
                .Select(x => indexElementsAbstractFactory.CreatesIndexElementFactory().Create((Organization)x.Resource))
                .ToImmutableList());

            // t
            IPlanningHorizonVisitor<INullableValue<int>, FhirDateTime> planningHorizonVisitor = contextsAbstractFactory.CreatePlanningHorizonVisitorFactory().Create<INullableValue<int>, FhirDateTime>(
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                indexElementsAbstractFactory.CreatetIndexElementFactory(),
                comparersAbstractFactory.CreateFhirDateTimeComparerFactory().Create());

            this.Context.PlanningHorizon.AcceptVisitor(
                planningHorizonVisitor);

            this.t = indicesAbstractFactory.CreatetFactory().Create(
                planningHorizonVisitor.RedBlackTree);

            // Λ
            this.Λ = indicesAbstractFactory.CreateΛFactory().Create(
                comparersAbstractFactory.CreateNullableValueintComparerFactory().Create(),
                this.Context.Scenarios
                .Select(x => indexElementsAbstractFactory.CreateΛIndexElementFactory().Create(x))
                .ToImmutableList());

            // υ1
            this.υ1 = indicesAbstractFactory.Createυ1Factory().Create(
                comparersAbstractFactory.CreateNullableValueintComparerFactory().Create(),
                this.Context.OperatingRoomServiceLevels
                .Select(x => indexElementsAbstractFactory.Createυ1IndexElementFactory().Create(x))
                .ToImmutableList());

            // Cross joins

            // sΛ
            this.sΛ = crossJoinsAbstractFactory.CreatesΛFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.Λ.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesΛCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // Parameters

            // A(s, υ1)
            ISurgeonServiceLevelNumberTimeBlocksOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> surgeonServiceLevelNumberTimeBlocksOuterVisitor = contextsAbstractFactory.CreateSurgeonServiceLevelNumberTimeBlocksOuterVisitorFactory().Create<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>>(
                contextsAbstractFactory.CreateSurgeonServiceLevelNumberTimeBlocksInnerVisitorFactory(),
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                parameterElementsAbstractFactory.CreateAParameterElementFactory(),
                this.s,
                this.υ1);

            this.Context.SurgeonServiceLevelNumberTimeBlocks.AcceptVisitor(
                surgeonServiceLevelNumberTimeBlocksOuterVisitor);

            this.A = parametersAbstractFactory.CreateAFactory().Create(
                surgeonServiceLevelNumberTimeBlocksOuterVisitor.RedBlackTree);

            // N(s)
            ISurgeonStrategicTargetsVisitor<Organization, INullableValue<int>> surgeonStrategicTargetsVisitor = contextsAbstractFactory.CreateSurgeonStrategicTargetsVisitorFactory().Create<Organization, INullableValue<int>>(
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                parameterElementsAbstractFactory.CreateNParameterElementFactory(),
                this.s);

            this.Context.SurgeonStrategicTargets.AcceptVisitor(
                surgeonStrategicTargetsVisitor);

            this.N = parametersAbstractFactory.CreateNFactory().Create(
                surgeonStrategicTargetsVisitor.RedBlackTree);

            // n(s, Λ)
            ISurgeonScenarioMaximumNumberPatientsOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> surgeonScenarioMaximumNumberPatientsOuterVisitor = contextsAbstractFactory.CreateSurgeonScenarioMaximumNumberPatientsOuterVisitorFactory().Create<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>>(
                contextsAbstractFactory.CreateSurgeonScenarioMaximumNumberPatientsInnerVisitorFactory(),
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                parameterElementsAbstractFactory.CreatenParameterElementFactory(),
                this.s,
                this.Λ);

            this.Context.SurgeonScenarioMaximumNumberPatients.AcceptVisitor(
                surgeonScenarioMaximumNumberPatientsOuterVisitor);

            this.n = parametersAbstractFactory.CreatenFactory().Create(
                surgeonScenarioMaximumNumberPatientsOuterVisitor.RedBlackTree);

            // Δ(j)
            ISurgicalSpecialtiesVisitor<Organization, ImmutableSortedSet<Organization>> surgicalSpecialtiesVisitor = contextsAbstractFactory.CreateSurgicalSpecialtiesVisitorFactory().Create<Organization, ImmutableSortedSet<Organization>>(
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                parameterElementsAbstractFactory.CreateΔParameterElementFactory(),
                this.j,
                this.s);

            this.Context.SurgicalSpecialties.AcceptVisitor(
                surgicalSpecialtiesVisitor);

            this.Δ = parametersAbstractFactory.CreateΔFactory().Create(
                surgicalSpecialtiesVisitor.RedBlackTree,
                surgicalSpecialtiesVisitor.Value.ToImmutableList());

            // Ρ(Λ)
            IScenarioProbabilitiesVisitor<INullableValue<int>, INullableValue<decimal>> scenarioProbabilitiesVisitor = contextsAbstractFactory.CreateScenarioProbabilitiesVisitorFactory().Create<INullableValue<int>, INullableValue<decimal>>(
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                parameterElementsAbstractFactory.CreateΡParameterElementFactory(),
                this.Λ);

            this.Context.ScenarioProbabilities.AcceptVisitor(
                scenarioProbabilitiesVisitor);

            this.Ρ = parametersAbstractFactory.CreateΡFactory().Create(
                scenarioProbabilitiesVisitor.RedBlackTree);

            // υ1Star
            this.υ1Star = parametersAbstractFactory.Createυ1StarFactory().Create(
                this.υ1.GetElementAt(this.Context.OptimalOperatingRoomServiceLevel));

            // υ1StarPlus1
            this.υ1StarPlus1 = parametersAbstractFactory.Createυ1StarPlus1Factory().Create(
                this.υ1.GetElementAt(this.Context.NextOperatingRoomServiceLevel));

            // ψ(t)
            IDayAvailabilitiesVisitor<FhirDateTime, INullableValue<bool>> dayAvailabilitiesVisitor = contextsAbstractFactory.CreateDayAvailabilitiesVisitorFactory().Create<FhirDateTime, INullableValue<bool>>(
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                parameterElementsAbstractFactory.CreateψParameterElementFactory(),
                this.t);

            this.Context.DayAvailabilities.AcceptVisitor(
                dayAvailabilitiesVisitor);

            this.ψ = parametersAbstractFactory.CreateψFactory().Create(
                dayAvailabilitiesVisitor.RedBlackTree);

            // ω(s)
            ISurgeonPenaltyWeightsVisitor<Organization, INullableValue<decimal>> surgeonPenaltyWeightsVisitor = contextsAbstractFactory.CreateSurgeonPenaltyWeightsVisitorFactory().Create<Organization, INullableValue<decimal>>(
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                parameterElementsAbstractFactory.CreateωParameterElementFactory(),
                this.s);

            this.Context.SurgeonPenaltyWeights.AcceptVisitor(
                surgeonPenaltyWeightsVisitor);

            this.ω = parametersAbstractFactory.CreateωFactory().Create(
                surgeonPenaltyWeightsVisitor.RedBlackTree);

            // Variables

            // B(s)
            this.B = variablesAbstractFactory.CreateBFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.s.Value.Values,    
                    lowerBoundGenerator: (a) => 0,
                    upperBoundGenerator: (a) => int.MaxValue, 
                    variableTypeGenerator: (a) => VariableType.Integer)); 

            // e1Minus(s, Λ)
            this.e1Minus = variablesAbstractFactory.Createe1MinusFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.s.Value.Values, 
                    indexSet2: this.Λ.Value.Values, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) => int.MaxValue,
                    variableTypeGenerator: (a, b) => VariableType.Integer)); 

            // e1Plus(s, Λ)
            this.e1Plus = variablesAbstractFactory.Createe1PlusFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.s.Value.Values, 
                    indexSet2: this.Λ.Value.Values,
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) => int.MaxValue,
                    variableTypeGenerator: (a, b) => VariableType.Integer)); 

            // Constraints

            // Constraints 1L
            this.Model.AddConstraints(
                this.s.Value.Values
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints1LConstraintElementFactory().Create(
                        x,
                        this.υ1Star.Value,
                        this.A,
                        this.B)
                    .Value));

            // Constraints 1U
            this.Model.AddConstraints(
                this.s.Value.Values
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints1UConstraintElementFactory().Create(
                        x,
                        this.υ1StarPlus1.Value,
                        this.A,
                        this.B)
                    .Value));

            // Constraint 2
            this.Model.AddConstraint(
                constraintsAbstractFactory.CreateConstraint2Factory().Create(
                    this.r,
                    this.s,
                    this.t,
                    this.ψ,
                    this.B)
                .Value);

            // Constraints 3
            this.Model.AddConstraints(
                this.sΛ.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints3ConstraintElementFactory().Create(
                        x.sIndexElement,
                        x.ΛIndexElement,
                        this.N,
                        this.n,
                        this.B,
                        this.e1Minus,
                        this.e1Plus)
                    .Value));
        }

        /// <summary>
        /// Gets the Context instance.
        /// </summary>
        public IHM1BInputContext Context { get; }

        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        public Model Model { get; }

        public Ij j { get; }

        public Ir r { get; }

        public Is s { get; }

        public It t { get; }

        public IΛ Λ { get; }

        public Iυ1 υ1 { get; }

        public IsΛ sΛ { get; }

        public IA A { get; }

        public IN N { get; }

        public In n { get; }

        public IΔ Δ { get; }

        public IΡ Ρ { get; }

        public Iυ1Star υ1Star { get; }

        public Iυ1StarPlus1 υ1StarPlus1 { get; }

        public Iψ ψ { get; }

        public Iω ω { get; }

        public IB B { get; }

        public Ie1Minus e1Minus { get; }

        public Ie1Plus e1Plus { get; }
    }
}
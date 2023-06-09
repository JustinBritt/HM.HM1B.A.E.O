namespace HM.HM1B.A.E.O.Classes.Models
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

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
            this.t = indicesAbstractFactory.CreatetFactory().Create(
                this.Context.PlanningHorizon
                .Select(x => indexElementsAbstractFactory.CreatetIndexElementFactory().Create(
                    x.Key.Value.Value,
                    x.Value))
                .ToImmutableList());

            // Λ
            this.Λ = indicesAbstractFactory.CreateΛFactory().Create(
                this.Context.Scenarios
                .Select(x => indexElementsAbstractFactory.CreateΛIndexElementFactory().Create((PositiveInt)x))
                .ToImmutableList());

            // υ1
            this.υ1 = indicesAbstractFactory.Createυ1Factory().Create(
                this.Context.OperatingRoomServiceLevels
                .Select(x => indexElementsAbstractFactory.Createυ1IndexElementFactory().Create((PositiveInt)x))
                .ToImmutableList());

            // Cross joins

            // sΛ
            this.sΛ = crossJoinsAbstractFactory.CreatesΛFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.Λ.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesΛCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // Parameters

            // A(s, υ1)
            this.A = parametersAbstractFactory.CreateAFactory().Create(
                this.Context.SurgeonServiceLevelNumberTimeBlocks
                .Select(x => parameterElementsAbstractFactory.CreateAParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.υ1.GetElementAt((PositiveInt)x.Item2),
                    (PositiveInt)x.Item3))
                .ToImmutableList());

            // N(s)
            this.N = parametersAbstractFactory.CreateNFactory().Create(
                this.Context.SurgeonStrategicTargets
                .Select(x => parameterElementsAbstractFactory.CreateNParameterElementFactory().Create(
                    this.s.GetElementAt(x.Key),
                    (PositiveInt)x.Value))
                .ToImmutableList());

            // n(s, Λ)
            this.n = parametersAbstractFactory.CreatenFactory().Create(
                this.Context.SurgeonScenarioMaximumNumberPatients
                .Select(x => parameterElementsAbstractFactory.CreatenParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.Λ.GetElementAt((PositiveInt)x.Item2),
                    (PositiveInt)x.Item3))
                .ToImmutableList());

            // Δ(j)
            ISurgicalSpecialtiesVisitor<Organization, ImmutableSortedSet<Organization>> surgicalSpecialtiesVisitor = new HM.HM1B.A.E.O.Visitors.Contexts.SurgicalSpecialtiesVisitor<Organization, ImmutableSortedSet<Organization>>(
                parameterElementsAbstractFactory.CreateΔParameterElementFactory(),
                this.j,
                this.s);

            this.Context.SurgicalSpecialties.AcceptVisitor(
                surgicalSpecialtiesVisitor);

            this.Δ = parametersAbstractFactory.CreateΔFactory().Create(
                surgicalSpecialtiesVisitor.RedBlackTree,
                surgicalSpecialtiesVisitor.Value.ToImmutableList());

            // Ρ(Λ)
            this.Ρ = parametersAbstractFactory.CreateΡFactory().Create(
                this.Context.ScenarioProbabilities
                .Select(x => parameterElementsAbstractFactory.CreateΡParameterElementFactory().Create(
                    this.Λ.GetElementAt((PositiveInt)x.Key),
                    (FhirDecimal)x.Value))
                .ToImmutableList());

            // υ1Star
            this.υ1Star = parametersAbstractFactory.Createυ1StarFactory().Create(
                this.υ1.GetElementAt((PositiveInt)this.Context.OptimalOperatingRoomServiceLevel));

            // υ1StarPlus1
            this.υ1StarPlus1 = parametersAbstractFactory.Createυ1StarPlus1Factory().Create(
                this.υ1.GetElementAt((PositiveInt)this.Context.NextOperatingRoomServiceLevel));

            // ψ(t)
            this.ψ = parametersAbstractFactory.CreateψFactory().Create(
                this.Context.DayAvailabilities
                .Select(x => parameterElementsAbstractFactory.CreateψParameterElementFactory().Create(
                    this.t.GetElementAt(x.Key),
                    (FhirBoolean)x.Value))
                .ToImmutableList());

            // ω(s)
            this.ω = parametersAbstractFactory.CreateωFactory().Create(
                this.Context.SurgeonPenaltyWeights
                .Select(x => parameterElementsAbstractFactory.CreateωParameterElementFactory().Create(
                    this.s.GetElementAt(x.Key),
                    (FhirDecimal)x.Value))
                .ToImmutableList());

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
                    indexSet2: this.Λ.Value, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) => int.MaxValue,
                    variableTypeGenerator: (a, b) => VariableType.Integer)); 

            // e1Plus(s, Λ)
            this.e1Plus = variablesAbstractFactory.Createe1PlusFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.s.Value.Values, 
                    indexSet2: this.Λ.Value,
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
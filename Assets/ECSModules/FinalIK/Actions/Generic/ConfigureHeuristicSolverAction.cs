using Assets.ECSModules.FinalIK.Extensions;
using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    public abstract class ConfigureHeuristicSolverAction : UFAction
    {
        [In]
        public float Tolerance;

        [In]
        public int MaxIterations;

        [In]
        public bool UseRotationLimits;

        protected abstract IKSolverHeuristic GetInternalSolver();

        public override void Execute()
        {
            var solver = GetInternalSolver();

            if(UseRotationLimits)
            { solver.useRotationLimits = UseRotationLimits; }

            if (Tolerance.IsNotZero())
            { solver.tolerance = Tolerance; }

            if(MaxIterations > 0)
            { solver.maxIterations = MaxIterations; }
        }
    }
}
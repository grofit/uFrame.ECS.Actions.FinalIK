using RootMotion.FinalIK;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Aim")]
    [ActionTitle("Configure Aim Solver")]
    [ActionDescription("Configure the settings for the aim solver")]
    public class ConfigureAimSolverAction : ConfigureHeuristicSolverAction
    {
        [In]
        public IKSolverAim Solver;

        protected override IKSolverHeuristic GetInternalSolver()
        { return Solver; }
    }
}
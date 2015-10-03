using RootMotion.FinalIK;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","CCDIK")]
    [ActionTitle("Configure Ccdik Solver")]
    [ActionDescription("Configure the settings for the ccdik solver")]
    public class ConfigureCCDIKSolverAction : ConfigureHeuristicSolverAction
    {
        [In]
        public IKSolverCCD Solver;

        protected override IKSolverHeuristic GetInternalSolver()
        { return Solver; }
    }
}
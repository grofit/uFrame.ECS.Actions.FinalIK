using RootMotion.FinalIK;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","FABRIK")]
    [ActionTitle("Configure Fabrik Solver")]
    [ActionDescription("Configure the settings for the FABRIK solver")]
    public class ConfigureFABRIKSolverAction : ConfigureHeuristicSolverAction
    {
        [In]
        public IKSolverFABRIK Solver;
        
        protected override IKSolverHeuristic GetInternalSolver()
        { return Solver; }
    }
}
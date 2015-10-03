using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Aim")]
    [ActionTitle("Set Aim Clamping")]
    [ActionDescription("Set the aim components clamp weighting")]
    public class SetAimClampingAction : UFAction
    {
        [In]
        public IKSolverAim Solver;

        [In]
        public float ClampWeighting;

        [In]
        public int ClampSmoothing;

        public override void Execute()
        {
            Solver.clampWeight = ClampWeighting;
            Solver.clampSmoothing = ClampSmoothing;
        }
    }
}
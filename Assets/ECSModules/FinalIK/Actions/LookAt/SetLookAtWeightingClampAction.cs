using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Look At")]
    [ActionTitle("Set Look At Weighting Clamp")]
    [ActionDescription("Influence the weighting clamp of the given Look At IK component")]
    public class SetLookAtWeightingClampAction : UFAction
    {
        [In]
        [Out]
        public IKSolverLookAt Solver;

        [In]
        public float ClampWeight;

        [In]
        public float ClampHeadWeight;

        [In]
        public float ClampEyesWeight;

        public override void Execute()
        {
            Solver.clampWeight = ClampWeight;
            Solver.clampWeightHead = ClampHeadWeight;
            Solver.clampWeightEyes = ClampEyesWeight;
        }
    }
}
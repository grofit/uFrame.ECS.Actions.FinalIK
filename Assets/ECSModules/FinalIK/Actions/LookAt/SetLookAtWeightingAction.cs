using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Look At")]
    [ActionTitle("Set Look At Weighting")]
    [ActionDescription("Sets the weighting influence of a Look At IK component")]
    
    public class SetLookAtWeightingAction : UFAction
    {
        [In]
        public IKSolverLookAt Solver;

        [In]
        public float BodyWeight;

        [In]
        public float HeadWeight;

        [In]
        public float EyesWeight;
        
        public override void Execute()
        {
            Solver.bodyWeight = BodyWeight;
            Solver.headWeight = HeadWeight;
            Solver.eyesWeight = EyesWeight;
        }
    }
}
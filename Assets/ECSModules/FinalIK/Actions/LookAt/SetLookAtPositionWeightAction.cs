using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Look At")]
    [ActionTitle("Set Look At Position Weighting")]
    [ActionDescription("Influence the positional weighting of the Look At IK component")]
    
    public class SetLookAtPositionWeightAction : UFAction
    {
        [In]
        public IKSolverLookAt Solver;

        [In]
        public float PositionWeight;
        
        public override void Execute()
        {
            Solver.IKPositionWeight = PositionWeight;
        }
    }
}
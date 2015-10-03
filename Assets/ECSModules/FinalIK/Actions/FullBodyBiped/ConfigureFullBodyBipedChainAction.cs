using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Full Body Biped")]
    [ActionTitle("Configure Full Body Biped Chain")]
    [ActionDescription("Gets the underlying body chain and configures it")]
    public class ConfigureFullBodyBipedChainAction : UFAction
    {
        [In]
        public IKSolverFullBodyBiped Solver;

        [In]
        public float SpineStiffness;

        [In]
        public float HorizonalPullWeight;

        [In]
        public float VerticalPullWeight;
        
        public override void Execute()
        {
            Solver.pullBodyHorizontal = HorizonalPullWeight;
            Solver.pullBodyVertical = VerticalPullWeight;
            Solver.spineStiffness = SpineStiffness;
        }
    }
}
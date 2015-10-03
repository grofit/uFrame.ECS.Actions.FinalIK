using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Full Body Biped")]
    [ActionTitle("Get Chains From Full Body Biped Solver")]
    [ActionDescription("Gets all the underlying chains from the Full Body Biped Solver")]
    
    public class GetChainsFromFullBodyBipedSolverAction : UFAction
    {
        [In]
        public IKSolverFullBodyBiped Solver;

        [Out]
        public FBIKChain LeftArm;

        [Out]
        public FBIKChain RightArm;

        [Out]
        public FBIKChain LeftLeg;

        [Out]
        public FBIKChain RightLeg;

        public override void Execute()
        {
            LeftArm = Solver.leftArmChain;
            RightArm = Solver.rightArmChain;
            LeftLeg = Solver.leftLegChain;
            RightLeg = Solver.rightLegChain;
        }
    }
}
using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Biped")]
    [ActionTitle("Get Limb Solvers From Biped")]
    [ActionDescription("Gets all the limb solvers from the Biped IK")]
    public class GetLimbSolversFromBipedAction : UFAction
    {
        [Out] public IKSolverLimb LeftFoot;

        [Out] public IKSolverLimb RightFoot;

        [Out] public IKSolverLimb LeftArm;

        [Out] public IKSolverLimb RightArm;
    
        public override void Execute()
        {
            var bipedIK = EntityView.GetComponent<BipedIK>();
            LeftFoot = bipedIK.solvers.leftFoot;
            RightFoot = bipedIK.solvers.rightFoot;
            LeftArm = bipedIK.solvers.leftHand;
            RightArm = bipedIK.solvers.rightHand;
        }
    }
}
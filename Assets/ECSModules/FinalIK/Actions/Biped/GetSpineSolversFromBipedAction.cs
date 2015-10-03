using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Biped")]
    [ActionTitle("Get Spine Solvers From Biped")]
    [ActionDescription("Gets the underlying spine solvers from the Biped IK")]
    public class GetSpineSolversFromBipedAction : UFAction
    {
        [Out]
        public IKSolverFABRIK Solvers;
        
        public override void Execute()
        {
            var bipedIK = EntityView.GetComponent<BipedIK>();
            Solvers = bipedIK.solvers.spine;
        }
    }
}
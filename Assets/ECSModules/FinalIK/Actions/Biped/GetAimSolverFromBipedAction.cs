using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Biped")]
    [ActionTitle("Get Aim Solver From Biped")]
    [ActionDescription("Gets the underlying aim solver from the Biped IK")]
    public class GetAimSolverFromBipedAction : UFAction
    {
        [Out]
        public IKSolverAim Solver;
        
        public override void Execute()
        {
            var bipedIK = EntityView.GetComponent<BipedIK>();
            Solver = bipedIK.solvers.aim;
        }
    }
}
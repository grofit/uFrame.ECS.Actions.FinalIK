using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Biped")]
    [ActionTitle("Get Look At Solver From Biped")]
    [ActionDescription("Gets the underlying Look At solver from the Biped IK")]
    public class GetLookAtSolverFromBipedAction : UFAction
    {
        [Out]
        public IKSolverLookAt Solver;
        
        public override void Execute()
        {
            var bipedIk = EntityView.GetComponent<BipedIK>();
            Solver = bipedIk.solvers.lookAt;
        }
    }
}
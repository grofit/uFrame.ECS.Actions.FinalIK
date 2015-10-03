using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Aim")]
    [ActionTitle("Get Solver From Aim")]
    [ActionDescription("Gets the underlying solver from the Aim IK")]
    public class GetSolverFromAimAction : UFAction
    {
        [Out]
        public IKSolverAim Solver;
        
        public override void Execute()
        {
            var aimIk = EntityView.GetComponent<AimIK>();

            Solver = aimIk.solver;
        }
    }
}
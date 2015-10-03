using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Limb")]
    [ActionTitle("Get Solver From Limb")]
    [ActionDescription("Gets the underlying solver from the LimbIK")]
    public class GetSolverFromLimbAction : UFAction
    {
        [Out]
        public IKSolverLimb Solver;
        
        public override void Execute()
        {
            var ik = EntityView.GetComponent<LimbIK>();
            Solver = ik.solver;
        }
    }
}
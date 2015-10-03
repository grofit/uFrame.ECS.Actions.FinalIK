using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Look At")]
    [ActionTitle("Get Solver From Look At")]
    [ActionDescription("Gets the underlying solver from the LookAt IK")]
    public class GetSolverFromLookAtAction : UFAction
    {
        [Out]
        public IKSolverLookAt Solver;
        
        public override void Execute()
        {
            var ik = EntityView.GetComponent<LookAtIK>();
            Solver = ik.solver;
        }
    }
}
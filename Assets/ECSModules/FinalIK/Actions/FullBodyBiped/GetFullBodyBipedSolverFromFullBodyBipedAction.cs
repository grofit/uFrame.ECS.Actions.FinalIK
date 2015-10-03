using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Full Body Biped")]
    [ActionTitle("Get Full Body Biped Solver")]
    [ActionDescription("Gets the underlying solver from the Full Body Biped IK")]
    public class GetFullBodyBipedSolverFromFullBodyBipedAction : UFAction
    {
        [Out]
        public IKSolverFullBodyBiped Solver;

        public override void Execute()
        {
            var ik = EntityView.GetComponent<FullBodyBipedIK>();
            Solver = ik.solver;
        }
    }
}
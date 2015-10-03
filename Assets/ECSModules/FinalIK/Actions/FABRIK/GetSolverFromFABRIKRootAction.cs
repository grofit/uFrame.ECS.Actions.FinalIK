using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","FABRIK")]
    [ActionTitle("Get Solver From Fabrik Root")]
    [ActionDescription("Gets the underlying solver from the FABRIK Root")]
    public class GetSolverFromFABRIKRootAction : UFAction
    {
        [Out]
        public IKSolverFABRIKRoot Solver;
        
        public override void Execute()
        {
            var ik = EntityView.GetComponent<FABRIKRoot>();
            Solver = ik.solver;
        }
    }
}
using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","FABRIK")]
    [ActionTitle("Get Solver From Fabrik")]
    [ActionDescription("Gets the underlying solver from the FABR IK")]
    public class GetSolverFromFABRIKAction : UFAction
    {
        [Out]
        public IKSolverFABRIK Solver;

        public override void Execute()
        {
            var fabrIK = EntityView.GetComponent<FABRIK>();
            Solver = fabrIK.solver;
        }
    }
}
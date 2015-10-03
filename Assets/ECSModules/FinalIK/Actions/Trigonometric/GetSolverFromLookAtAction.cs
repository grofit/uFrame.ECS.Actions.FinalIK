using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Trigonometric")]
    [ActionTitle("Get Solver From Trigonometric")]
    [ActionDescription("Gets the underlying solver from the Trigonometric IK")]
    public class GetSolverFromTrigonometricAction : UFAction
    {
        [Out]
        public IKSolverTrigonometric Solver;
        
        public override void Execute()
        {
            var ik = EntityView.GetComponent<TrigonometricIK>();
            Solver = ik.solver;
        }
    }
}
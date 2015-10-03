using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","CCDIK")]
    [ActionTitle("Get Solver From CCDIK")]
    [ActionDescription("Gets the underlying solver from the CCD IK")]
    public class GetSolverFromCCDIKAction : UFAction
    {
        [Out]
        public IKSolverCCD Solver;
        
        public override void Execute()
        {
            var ccdik = EntityView.GetComponent<CCDIK>();
            Solver = ccdik.solver;
        }
    }
}
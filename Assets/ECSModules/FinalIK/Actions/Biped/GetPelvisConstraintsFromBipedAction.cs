using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Biped")]
    [ActionTitle("Get Pelvis Constraints From Biped")]
    [ActionDescription("Gets the underlying pelvis constraints from the Biped IK")]
    public class GetPelvisConstraintsFromBipedAction : UFAction
    {
        [Out]
        public Constraints Constraints;
        
        public override void Execute()
        {
            var bipedIK = EntityView.GetComponent<BipedIK>();
            Constraints = bipedIK.solvers.pelvis;
        }
    }
}
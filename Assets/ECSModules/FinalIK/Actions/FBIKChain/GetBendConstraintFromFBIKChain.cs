using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","FBIK Chain")]
    [ActionTitle("Get Bend Constraint From Fbik Chain")]
    [ActionDescription("Get the underlying bend constraint from the FBIKChain")]
    public class GetBendConstraintFromFBIKChain : UFAction
    {
        [In]
        public FBIKChain Chain;

        [Out]
        public IKConstraintBend Constraint;

        public override void Execute()
        {
            Constraint = Chain.bendConstraint;
        }
    }
}
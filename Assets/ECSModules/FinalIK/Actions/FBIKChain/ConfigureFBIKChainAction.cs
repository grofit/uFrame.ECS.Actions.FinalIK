using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","FBIK Chain")]
    [ActionTitle("Configure FbikChain")]
    [ActionDescription("Configure the FBIK chain")]
    public class ConfigureFBIKChainAction : UFAction
    {
        [In]
        public FBIKChain Chain;

        [In]
        public float PullWeight;

        [In]
        public float ReachWeight;

        [In]
        public float PushWeight;

        [In]
        public float PushParent;

        [In]
        public FBIKChain.Smoothing ReachSmoothing = FBIKChain.Smoothing.Exponential;

        [In]
        public FBIKChain.Smoothing PushSmoothing = FBIKChain.Smoothing.Exponential;

        public override void Execute()
        {
            Chain.pull = PullWeight;
            Chain.reach = ReachWeight;
            Chain.push = PushWeight;
            Chain.pushParent = PushParent;

            Chain.reachSmoothing = ReachSmoothing;
            Chain.pushSmoothing = PushSmoothing;
        }
    }
}
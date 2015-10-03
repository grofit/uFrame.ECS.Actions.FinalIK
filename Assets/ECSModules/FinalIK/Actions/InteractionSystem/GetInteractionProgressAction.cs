using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Interaction System")]
    [ActionTitle("Get Interaction Progress")]
    [ActionDescription("Get interaction progress using the interaction system")]
    public class GetInteractionProgressAction : UFAction
    {
        [In]
        public FullBodyBipedEffector BipedEffectorType;

        [Out]
        public float InteractionProgress;
            
        public override void Execute()
        {
            var interactionSystem = EntityView.GetComponent<InteractionSystem>();
            InteractionProgress = interactionSystem.GetProgress(BipedEffectorType);
        }
    }
}
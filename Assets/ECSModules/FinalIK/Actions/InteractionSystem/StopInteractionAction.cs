using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Interaction System")]
    [ActionTitle("Stop Interaction")]
    [ActionDescription("Stop interaction using the interaction system")]
    public class StopInteractionAction : UFAction
    {
        [In]
        public FullBodyBipedEffector BipedEffectorType;
        
        public override void Execute()
        {
            var interactionSystem = EntityView.GetComponent<InteractionSystem>();
            interactionSystem.StopInteraction(BipedEffectorType);
        }
    }
}
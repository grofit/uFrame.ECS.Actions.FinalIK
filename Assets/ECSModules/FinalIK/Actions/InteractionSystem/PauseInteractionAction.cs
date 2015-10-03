using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Interaction System")]
    [ActionTitle("Pause Interaction")]
    [ActionDescription("Pause interaction using the interaction system")]
    public class PauseInteractionAction : UFAction
    {
        [In]
        public FullBodyBipedEffector BipedEffectorType;

        public override void Execute()
        {
            var interactionSystem = EntityView.GetComponent<InteractionSystem>();
            interactionSystem.PauseInteraction(BipedEffectorType);
        }
    }
}
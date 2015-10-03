using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Interaction System")]
    [ActionTitle("Resume Interaction")]
    [ActionDescription("Resume interaction using the interaction system")]
    public class ResumeInteractionAction : UFAction
    {
        [In]
        public FullBodyBipedEffector BipedEffectorType;
       
        public override void Execute()
        {
            var interactionSystem = EntityView.GetComponent<InteractionSystem>();
            interactionSystem.ResumeInteraction(BipedEffectorType);
        }
    }
}
using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Interaction System")]
    [ActionTitle("Start Interaction")]
    [ActionDescription("Start interaction using the interaction system")]
    public class StartInteractionAction : UFAction
    {
        [In]
        public GameObject InteractionObject;

        [In]
        public bool Interrupt;

        [In]
        public FullBodyBipedEffector BipedEffectorType;

        public override void Execute()
        {
            var interactionSystem = EntityView.GetComponent<InteractionSystem>();
            var interactionObject = EntityView.GetComponent<InteractionObject>();
            interactionSystem.StartInteraction(BipedEffectorType, interactionObject, Interrupt);
        }
    }
}
using System;
using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Interaction System")]
    [ActionTitle("Is Child Interacting")]
    [ActionDescription("Checks an interaction child using the interaction system")]
    public class IsChildInteractingCondition : UFAction
    {
        [In]
        public FullBodyBipedEffector BipedEffectorType;

        [Out]
        public Action True;
        [Out]
        public Action False;

        public override void Execute()
        {
            var interactionSystem = EntityView.GetComponent<InteractionSystem>();
            if(interactionSystem.IsInInteraction(BipedEffectorType))
            { True(); }
            else
            { False(); }
        }
    }
}
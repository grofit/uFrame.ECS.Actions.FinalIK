using System;
using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Interaction System")]
    [ActionTitle("Is Interacting")]
    [ActionDescription("Checks an interaction using the interaction system")]
    public class IsInteractingCondition : UFAction
    {

        [Out] public Action True;
        [Out] public Action False;

        public override void Execute()
        {
            var interactionSystem = EntityView.GetComponent<InteractionSystem>();
            if(interactionSystem.inInteraction)
            { True(); }
            else
            { False(); }
        }
    }
}
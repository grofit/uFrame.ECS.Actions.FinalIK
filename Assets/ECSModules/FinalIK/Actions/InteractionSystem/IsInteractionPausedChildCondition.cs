using System;
using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Interaction System")]
    [ActionTitle("Is Interaction Child Paused")]
    [ActionDescription("Start interaction using the interaction system")]
    public class IsInteractionPausedChildCondition : UFAction
    {
        [In]
        public FullBodyBipedEffector BipedEffectorType;

        [Out] public Action True;
        [Out] public Action False;

        public override void Execute()
        {
            var interactionSystem = EntityView.GetComponent<InteractionSystem>();
            if(interactionSystem.IsPaused(BipedEffectorType))
            { True(); }
            else
            { False(); }
        }
    }
}
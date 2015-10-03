using System;
using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Interaction System")]
    [ActionTitle("Is Interaction Paused")]
    [ActionDescription("Start interaction using the interaction system")]
    public class IsInteractionPausedCondition : UFAction
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
            if(interactionSystem.IsPaused())
            { True(); }
            else
            { False(); }
        }
    }
}
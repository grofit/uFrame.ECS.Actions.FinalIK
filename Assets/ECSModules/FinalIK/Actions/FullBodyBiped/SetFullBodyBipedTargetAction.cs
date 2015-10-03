using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Full Body Biped")]
    [ActionTitle("Set Full Body Biped Target")]
    [ActionDescription("Configure the target and weighting settings for the full body biped solver")]
    public class SetFullBodyBipedTargetAction : UFAction
    {
        [In]
        public IKSolverFullBodyBiped Solver;

        [In]
        public Transform TargetTransform;

        [In]
        public float PositionWeight;

        public override void Execute()
        {
            Solver.IKPosition = TargetTransform.position;
            Solver.IKPositionWeight = PositionWeight;
        }
    }
}
using Assets.ECSModules.FinalIK.Extensions;
using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Effector")]
    [ActionTitle("Set Ik Effector Target")]
    [ActionDescription("Influence the IK Effectors target interaction")]
    public class SetIKEffectorTargetAction : UFAction
    {
        [In]
        public IKEffector Effector;

        [In]
        public GameObject Target;

        [In]
        public float PositionWeight;

        [In]
        public float RotationWeight;

        [In]
        public float MaintainRelativePositionWeight;

        public override void Execute()
        {
            Effector.target = Target.transform;
            Effector.positionWeight = PositionWeight;
            Effector.rotationWeight = RotationWeight;
            Effector.maintainRelativePositionWeight = MaintainRelativePositionWeight;
        }
    }
}
using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Aim")]
    [ActionTitle("Simple Pole Aim At Target")]
    [ActionDescription("A simple task wrapping up underlying functionality to pole aim at a target directly from the IK")]
    public class SimplePoleAimAtTargetAction : UFAction
    {
        [In]
        public Transform Effector;

        [In]
        public float PositionWeight;

        [In]
        public Vector3 Axis = Vector3.up;

        public override void Execute()
        {
            var aimIK = EntityView.GetComponent<AimIK>();
            aimIK.solver.poleTarget = Effector.transform;
            aimIK.solver.poleWeight = PositionWeight;
            aimIK.solver.axis = Axis;
        }
    }
}
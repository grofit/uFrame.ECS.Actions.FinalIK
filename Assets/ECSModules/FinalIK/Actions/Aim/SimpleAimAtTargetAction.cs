using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Aim")]
    [ActionTitle("Simple Aim At Target")]
    [ActionDescription("A simple task wrapping up underlying functionality to aim at a target directly from the IK")]
    public class SimpleAimAtTargetAction : UFAction
    {
        [In]
        public Transform Effector;
        
        [In]
        public float PositionWeight;

        [In]
        public Vector3 Axis = Vector3.forward;

        public override void Execute()
        {
            var aimIK = EntityView.GetComponent<AimIK>();
            aimIK.solver.IKPosition = Effector.transform.position;
            aimIK.solver.IKPositionWeight = PositionWeight;
            aimIK.solver.axis = Axis;
        }
    }
}
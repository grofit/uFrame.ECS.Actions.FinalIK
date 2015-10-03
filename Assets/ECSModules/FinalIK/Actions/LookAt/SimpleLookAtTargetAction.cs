using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Look At")]
    [ActionTitle("Simple Look At Target")]
    [ActionDescription("A simple task wrapping up underlying functionality to target directly from the IK")]
    public class SimpleLookAtTargetAction : UFAction
    {
        [In]
        public Transform Effector;
        
        [In]
        public float PositionWeight;
        
        public override void Execute()
        {
            var ik = EntityView.GetComponent<LookAtIK>();
            ik.solver.IKPosition = Effector.transform.position;
            ik.solver.IKPositionWeight = PositionWeight;
        }
    }
}
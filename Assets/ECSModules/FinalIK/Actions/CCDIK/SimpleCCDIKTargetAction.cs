using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","CCDIK")]
    [ActionTitle("Simple CCDIK Target")]
    [ActionDescription("A simple task wrapping up underlying functionality to target directly from the IK")]
    public class SimpleCCDIKTargetAction : UFAction
    {
        [In]
        public Transform Effector;
        
        [In]
        public float PositionWeight;
        
        public override void Execute()
        {
            var ccdik = EntityView.GetComponent<CCDIK>();
            ccdik.solver.IKPosition = Effector.transform.position;
            ccdik.solver.IKPositionWeight = PositionWeight;
        }
    }
}
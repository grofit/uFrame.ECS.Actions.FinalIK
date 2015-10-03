using Assets.ECSModules.FinalIK.Extensions;
using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","CCDIK")]
    [ActionTitle("Set Ccdik Solver Target")]
    [ActionDescription("Influence limb solver to target an effector")]
    
    public class SetCCDIKSolverTargetAction : UFAction
    {
        [In]
        public IKSolverCCD Solver;

        [In]
        public Transform Effector;

        [In]
        public float PositionWeight;

        public override void Execute()
        {
            Solver.IKPosition = Effector.transform.position;
            Solver.IKPositionWeight = PositionWeight;
        }
    }
}
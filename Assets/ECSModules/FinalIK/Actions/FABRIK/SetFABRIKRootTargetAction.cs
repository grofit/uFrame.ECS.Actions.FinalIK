using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","FABRIK")]
    [ActionTitle("Set Fabrik Root Target")]
    [ActionDescription("Influence FABRIK Root solver target")]
    
    public class SetFABRIKRootTargetAction : UFAction
    {
        [In]
        public IKSolverFABRIKRoot Solver;

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
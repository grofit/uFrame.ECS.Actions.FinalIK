using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","FABRIK")]
    [ActionTitle("Set Fabrik Target")]
    [ActionDescription("Influence FABRIK solver target")]
    public class SetFABRIKTargetAction : UFAction
    {
        [In]
        public IKSolverFABRIK Solver;

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
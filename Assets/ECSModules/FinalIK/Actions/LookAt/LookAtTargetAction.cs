using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Look At")]
    [ActionTitle("Look At Target")]
    [ActionDescription("Influence the Look At IK component to look at a given target")]
    public class LookAtTargetAction : UFAction
    {
        [In]
        public IKSolverLookAt Solver;

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
using Assets.ECSModules.FinalIK.Extensions;
using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Aim")]
    [ActionTitle("Pole Aim At GameObject")]
    [ActionDescription("Influence the Aim IK component to pole aim at a given game object")]
    public class PoleAimSolverAtTargetAction : UFAction
    {
        [In]
        public IKSolverAim Solver;

        [In]
        public Transform Effector;

        [In]
        public float PositionWeight;
        
        public override void Execute()
        {
            Solver.poleTarget = Effector.transform;
            Solver.poleWeight = PositionWeight;
        }
    }
}
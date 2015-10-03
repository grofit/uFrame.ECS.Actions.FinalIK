using System.ComponentModel;
using Assets.ECSModules.FinalIK.Extensions;
using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Aim")]
    [ActionTitle("Aim At Target")]
    [ActionDescription("Influence the Aim Solver component to aim at a given target")]
    public class AimSolverAtTargetAction : UFAction
    {
        [In]
        public IKSolverAim Solver;

        [In]
        public Transform Effector;
        
        [In]
        public float PositionWeight;
        
        public override void Execute()
        {
            Solver.IKPosition = Effector.position;
            Solver.IKPositionWeight = PositionWeight;
        }
    }
}
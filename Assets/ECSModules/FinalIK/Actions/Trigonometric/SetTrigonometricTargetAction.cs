using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Trigonometric")]
    [ActionTitle("Set Trigonometric Target")]
    [ActionDescription("Configure the target and weighting settings for the trigonometric solver")]
    
    public class SetTrigonometricTargetAction : UFAction
    {
        [In]
        public IKSolverTrigonometric Solver;

        [In]
        public GameObject PositionTarget;

        [In]
        public GameObject RotationTarget;

        [In]
        public float PositionWeight;

        [In]
        public float RotationWeight;

        public override void Execute()
        {
            Solver.IKPosition = PositionTarget.transform.position;
            Solver.IKRotation = RotationTarget.transform.rotation;

            Solver.IKPositionWeight = PositionWeight;
            Solver.IKRotationWeight = RotationWeight;
        }
    }
}
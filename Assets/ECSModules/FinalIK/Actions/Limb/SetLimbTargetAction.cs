using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Limb")]
    [ActionTitle("Set Limb Target")]
    [ActionDescription("Influence limb solver to target an effector")]
    
    public class SetLimbTargetAction : UFAction
    {
        [In]
        public IKSolverLimb Solver;

        [In]
        public GameObject PositionEffector;

        [In]
        public float PositionWeight;

        [In]
        public GameObject RotationEffector;

        [In]
        public float RotationWeight;

        [In]
        public IKSolverLimb.BendModifier BendModifier = IKSolverLimb.BendModifier.Animation;

        public override void Execute()
        {
            Solver.IKPosition = PositionEffector.transform.position;
            Solver.IKRotation = RotationEffector.transform.rotation;
            Solver.bendModifier = BendModifier;

            Solver.IKPositionWeight = PositionWeight;
            Solver.IKRotationWeight = RotationWeight;
        }
    }
}
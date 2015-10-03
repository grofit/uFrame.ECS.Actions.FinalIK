using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Look At")]
    [ActionTitle("Set Look At Spine Curves")]
    [ActionDescription("Influence spinal curves of the Look At IK component")]
    public class SetLookAtSpineCurveAction : UFAction
    {
        [In]
        public IKSolverLookAt Solver;

        [In]
        public AnimationCurve SpineWeightCurve;

        public override void Execute()
        {
            Solver.spineWeightCurve = SpineWeightCurve;
        }
    }
}
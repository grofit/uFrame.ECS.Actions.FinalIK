using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Aim")]
    [ActionTitle("Set Aim Transform")]
    [ActionDescription("Influence the Aim solvers transform values")]
    public class SetAimTransformAction : UFAction
    {
        [In]
        public IKSolverAim Solver;

        [In]
        public Transform Transform;

        [In]
        public Vector3 TransformAxis;

        public override void Execute()
        {
            Solver.transform = Transform;
            Solver.axis = TransformAxis;
        }
    }
}
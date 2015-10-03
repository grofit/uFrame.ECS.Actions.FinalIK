using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Trigonometric")]
    [ActionTitle("Configure Trigonometric Solver")]
    [ActionDescription("Configure the trigonometric solver")]
    public class ConfigureTrigonometricSolverAction : UFAction
    {
        [In]
        public IKSolverTrigonometric Solver;

        [In]
        public Vector3 BendNormal;

        public override void Execute()
        {
            Solver.bendNormal = BendNormal;
        }
    }
}
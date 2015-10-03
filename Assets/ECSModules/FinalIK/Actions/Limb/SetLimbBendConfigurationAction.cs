using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Limb")]
    [ActionTitle("Set Limb Bend Configuration")]
    [ActionDescription("Set the limb bend configurations, such as bend modifiers and bend goals")]
    public class SetLimbBendConfigurationAction : UFAction
    {
        [In]
        public IKSolverLimb Solver;
        
        [In]
        public IKSolverLimb.BendModifier BendModifier = IKSolverLimb.BendModifier.Animation;

        [In]
        public float BendWeight;

        [In]
        public Transform BendGoal;

        public override void Execute()
        {
            Solver.bendModifier = BendModifier;
            Solver.bendModifierWeight = BendWeight;
            Solver.bendGoal = BendGoal;
        }
    }
}
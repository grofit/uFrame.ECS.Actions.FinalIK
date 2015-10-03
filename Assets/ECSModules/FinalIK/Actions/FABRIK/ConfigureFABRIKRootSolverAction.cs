using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","FABRIK")]
    [ActionTitle("Configure Fabrik Root Solver")]
    [ActionDescription("Configure the settings for the FABRIK root solver")]
    
    public class ConfigureFABRIKRootSolverAction : UFAction
    {
        [In]
        public IKSolverFABRIKRoot Solver;

        [In]
        public float PinWeight;

        public int Iterations;

        public override void Execute()
        {
            Solver.iterations = Iterations; 
            Solver.rootPin = PinWeight;
        }
    }
}
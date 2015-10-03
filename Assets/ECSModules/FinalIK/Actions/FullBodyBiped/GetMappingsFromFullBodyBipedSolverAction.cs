using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Full Body Biped")]
    [ActionTitle("Get Mappings From Full Body Biped Solver")]
    [ActionDescription("Gets all the underlying mappings from the Full Body Biped Solver")]
    public class GetMappingsFromFullBodyBipedSolverAction : UFAction
    {
        [In]
        public IKSolverFullBodyBiped Solver;

        [Out]
        public IKMappingBone Head;

        [Out]
        public IKMappingLimb LeftArmLimbMapping;

        [Out]
        public IKMappingLimb RightArmLimbMapping;

        [Out]
        public IKMappingLimb LeftLegLimbMapping;

        [Out]
        public IKMappingLimb RightLegLimbMapping;

        [Out]
        public IKMappingSpine SpineMapping;

        public override void Execute()
        {
            Head = Solver.headMapping;
            LeftArmLimbMapping = Solver.leftArmMapping;
            RightArmLimbMapping = Solver.rightArmMapping;
            LeftLegLimbMapping = Solver.leftLegMapping;
            RightLegLimbMapping = Solver.rightLegMapping;
            SpineMapping = Solver.spineMapping;
        }
    }
}
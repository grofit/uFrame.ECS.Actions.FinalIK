using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Full Body Biped")]
    [ActionTitle("Get Effectors From Full Body Biped Solver")]
    [ActionDescription("Gets all the underlying effectors from the Full Body Biped Solver")]
    public class GetEffectorsFromFullBodyBipedSolverAction : UFAction
    {
        [In]
        public IKSolverFullBodyBiped Solver;

        [Out]
        public IKEffector Body;

        [Out]
        public IKEffector LeftFoot;

        [Out]
        public IKEffector LeftHand;

        [Out]
        public IKEffector LeftShoulder;

        [Out]
        public IKEffector LeftThigh;

        [Out]
        public IKEffector RightFoot;

        [Out]
        public IKEffector RightHand;

        [Out]
        public IKEffector RightShoulder;

        [Out]
        public IKEffector RightThigh;

        public override void Execute()
        {
            Body = Solver.bodyEffector;
            LeftFoot = Solver.leftFootEffector;
            LeftHand = Solver.leftHandEffector;
            LeftShoulder = Solver.leftShoulderEffector;
            LeftThigh = Solver.leftThighEffector;
            RightFoot = Solver.rightFootEffector;
            RightHand = Solver.rightHandEffector;
            RightShoulder = Solver.rightShoulderEffector;
            RightThigh = Solver.rightThighEffector;
        }
    }
}
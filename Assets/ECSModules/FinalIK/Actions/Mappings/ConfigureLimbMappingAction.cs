using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Mappings")]
    [ActionTitle("Configure Limb Mapping")]
    [ActionDescription("Configure the limb mapping")]
    public class ConfigureLimbMappingAction : UFAction
    {
        [In]
        public IKMappingLimb Mapping;

        [In]
        public float Weight;

        [In]
        public float MaintainRotationWeight;

        public override void Execute()
        {
            Mapping.weight = Weight;
            Mapping.maintainRotationWeight = MaintainRotationWeight;
        }
    }
}
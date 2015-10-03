using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Mappings")]
    [ActionTitle("Configure Bone Mapping")]
    [ActionDescription("Configure the bone mapping")]
    public class ConfigureBoneMappingAction : UFAction
    {
        [In]
        public IKMappingBone BoneMapping;

        [In]
        public float MaintainRotationWeight;

        public override void Execute()
        {
            BoneMapping.maintainRotationWeight = MaintainRotationWeight;
        }
    }
}
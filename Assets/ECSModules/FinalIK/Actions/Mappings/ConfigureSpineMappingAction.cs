using RootMotion.FinalIK;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.FinalIK
{
    [uFrameCategory("FinalIK","Mappings")]
    [ActionTitle("Configure Spine Mapping")]
    [ActionDescription("Configure the spine mapping")]
    
    public class ConfigureSpineMappingAction : UFAction
    {
        [In]
        public IKMappingSpine SpineMapping;

        [In]
        public float TwistWeight;
        
        public int Iterations;

        public override void Execute()
        {
            SpineMapping.twistWeight = TwistWeight;
            SpineMapping.iterations = Iterations;
        }
    }
}
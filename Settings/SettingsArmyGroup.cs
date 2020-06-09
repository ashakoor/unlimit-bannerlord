using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;

namespace UnlimitLord.Settings
{
    internal sealed partial class McmSettings
    {
        [SettingPropertyGroup("Army", GroupOrder = 3)]
        public bool ArmyCategory { get; set; }

        //

        [SettingPropertyGroup("Army/Cohesion", IsMainToggle = true)]
        [SettingPropertyBool("Army Cohesion Enabled", RequireRestart = false)]
        public bool ArmyCohesionEnabled { get; set; } = false;

        [SettingPropertyGroup("Army/Cohesion")]
        [SettingPropertyFloatingInteger("Cohesion Change Multiplier", 0f, 10f, "00.00x", Order = 0, RequireRestart = false)]
        public float ArmyCohesionMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("Army/Cohesion")]
        [SettingPropertyFloatingInteger("Min. Cohesion", 0f, 100f, "00.00", Order = 1, RequireRestart = false)]
        public float MinCohesion { get; set; } = 0f;

        [SettingPropertyGroup("Army/Cohesion")]
        [SettingPropertyFloatingInteger("Max. Cohesion", 0f, 100f, "00.00", Order = 2, RequireRestart = false)]
        public float MaxCohesion { get; set; } = 100f;
    }
}
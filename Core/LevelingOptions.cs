using BepInEx.Configuration;

namespace EasySkillOptions.Core
{
    internal static class LevelingOptions
    {
        public static ConfigEntry<bool> enableAdvancedLevelingMod;
        public static ConfigEntry<float> freshSkillPoints;
        public static ConfigEntry<float> skillPointsBeforeFatique;
        public static ConfigEntry<float> skillPointsResetTime;
        public static ConfigEntry<float> skillPointsFreshEffectivness;
        public static ConfigEntry<float> skillFatiquePerPoint;
        public static ConfigEntry<float> skillMinEffectiveness;
        public static ConfigEntry<float> skillProgressRate;
        public static ConfigEntry<bool> enableAtrophy;

        public static void RegisterConfig(ConfigFile Config)
        {
            //string mainLevelingMods = "Simple Leveling Modifier";
            string advancedLevelingMods = "Advanced Leveling Modifiers";
         
            enableAdvancedLevelingMod = Config.Bind(
               advancedLevelingMods,
               "Enable advanced leveling config",
               false,
               "Enables the advanced leveling configs. if enabled disables the simple leveling modifier");

            freshSkillPoints = Config.Bind(
               advancedLevelingMods,
               "Fresh skill points",
               1f,
               new ConfigDescription("Amount of fresh skill points you have", new AcceptableValueRange<float>(1, 100)));

            skillPointsBeforeFatique = Config.Bind(
               advancedLevelingMods,
               "skill points before fatique",
               2f,
               new ConfigDescription("Amount of fresh skill points before skill fatique kicks in", new AcceptableValueRange<float>(1, 100)));

            skillPointsResetTime = Config.Bind(
               advancedLevelingMods,
               "skill point fatique reset time",
               300f,
               new ConfigDescription("Amount of time in seconds before fatique resets", new AcceptableValueRange<float>(1, 1000)));

            skillPointsFreshEffectivness = Config.Bind(
               advancedLevelingMods,
               "Fresh skill point multiplier",
               1.2f,
               new ConfigDescription("Multiplies the points per action of fresh points", new AcceptableValueRange<float>(1, 10)));

            skillFatiquePerPoint = Config.Bind(
               advancedLevelingMods,
               "Skill fatique per point",
               0.5f,
               new ConfigDescription("How much fatique is accumulated per skill point gained", new AcceptableValueRange<float>(0, 10)));

            skillMinEffectiveness = Config.Bind(
               advancedLevelingMods,
               "Min skill effectiveness",
               0.01f,
               new ConfigDescription("minimum skill point gained per action", new AcceptableValueRange<float>(0, 10)));

            skillProgressRate = Config.Bind(
               advancedLevelingMods,
               "Skill progress rate",
               0.4f,
               new ConfigDescription("How often actions can occur", new AcceptableValueRange<float>(0, 10)));

            enableAtrophy = Config.Bind(
               advancedLevelingMods,
               "Enable skill atrophy(regression)",
               true,
               "Enables the roll back of skills");
        }

        public static void SetadvancedLeveling()
        {
            // If the backend is null
            // or the mod is not enabled, return early
            if (Plugin.BackendConfig == null || !enableAdvancedLevelingMod.Value)
            {
                return;
            }

            SetOriginalValues();
            SetSkillPoints();
        }

        private static void SetOriginalValues()
        {
            // Fatique
            Plugin.BackendConfig.SkillPointsBeforeFatigue = 1;
            Plugin.BackendConfig.SkillFatiguePerPoint = 0.6f;
            Plugin.BackendConfig.SkillFatigueReset = 300;

            // Progression Multipliers
            Plugin.BackendConfig.SkillMinEffectiveness = 0.01f;
            Plugin.BackendConfig.SkillFatiguePerPoint = 0.5f;
            Plugin.BackendConfig.SkillFreshPoints = 1;
            Plugin.BackendConfig.SkillMinEffectiveness = 0.0001f;
            Plugin.BackendConfig.SkillsSettings.SkillProgressRate = 0.4f;
        }

        private static void SetSkillPoints()
        {
            if (Plugin.BackendConfig.SkillFreshPoints != freshSkillPoints.Value)
            {
                Plugin.BackendConfig.SkillFreshPoints = (int)freshSkillPoints.Value;
            }

            if (Plugin.BackendConfig.SkillPointsBeforeFatigue != skillPointsBeforeFatique.Value)
            {
                Plugin.BackendConfig.SkillPointsBeforeFatigue = (int)skillPointsBeforeFatique.Value;
            }

            if (Plugin.BackendConfig.SkillFatigueReset != skillPointsResetTime.Value)
            {
                Plugin.BackendConfig.SkillPointsBeforeFatigue = (int)skillPointsResetTime.Value;
            }

            if (Plugin.BackendConfig.SkillFatigueReset != skillPointsResetTime.Value)
            {
                Plugin.BackendConfig.SkillPointsBeforeFatigue = (int)skillPointsResetTime.Value;
            }

            if (Plugin.BackendConfig.SkillFreshEffectiveness != skillPointsFreshEffectivness.Value)
            {
                Plugin.BackendConfig.SkillFreshEffectiveness = skillPointsFreshEffectivness.Value;
            }

            if (Plugin.BackendConfig.SkillFatiguePerPoint != skillFatiquePerPoint.Value)
            {
                Plugin.BackendConfig.SkillFatiguePerPoint = skillFatiquePerPoint.Value;
            }

            if (Plugin.BackendConfig.SkillMinEffectiveness != skillMinEffectiveness.Value)
            {
                Plugin.BackendConfig.SkillMinEffectiveness = skillMinEffectiveness.Value;
            }

            if (Plugin.BackendConfig.SkillsSettings.SkillProgressRate != skillProgressRate.Value)
            {
                Plugin.BackendConfig.SkillsSettings.SkillProgressRate = skillProgressRate.Value;
            }

            if (enableAtrophy.Value && Plugin.BackendConfig.SkillAtrophy == false)
            {
                Plugin.BackendConfig.SkillAtrophy = true;

            }
            else if (!enableAtrophy.Value && Plugin.BackendConfig.SkillAtrophy == true)
            {
                Plugin.BackendConfig.SkillAtrophy = false;
            }
        }
    }
}

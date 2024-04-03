using Aki.Reflection.Utils;
using BepInEx;
using BepInEx.Configuration;
using Comfort.Common;
using DrakiaXYZ.VersionChecker;
using EasySkillOptions.Core;
using EasySkillOptions.Patches;
using EFT;
using System;

namespace EasySkillOptions
{
    [BepInPlugin("com.dirtbikercj.EasySkillOptions", "Easy Skill Options", "2.1.0")]
    internal class Plugin : BaseUnityPlugin
    {
        public const int TarkovVersion = 29197;

        internal static Plugin Instance;
        internal static BackendConfigSettingsClass BackendConfig;
        internal static SkillManager SkillManager;

        private void Awake()
        {
            if (!VersionChecker.CheckEftVersion(Logger, Info, Config))
            {
                throw new Exception("Invalid EFT Version");
            }
    
            BackendConfig = Singleton<BackendConfigSettingsClass>.Instance;

            Instance = this;
            DontDestroyOnLoad(Instance);

            new OnGameStartedPatch().Enable();

            EliteSkillToggles.RegisterConfig(Config);
            LevelingOptions.RegisterConfig(Config);
        }   

        private void Update()
        {
            if (Singleton<GameWorld>.Instantiated && BackendConfig != null && SkillManager != null)
            {
                EliteSkillToggles.SetToggles();
                LevelingOptions.SetadvancedLeveling();
            }
            else
            {
                SkillManager = null;
                BackendConfig = null;
            }
        }
    }
}

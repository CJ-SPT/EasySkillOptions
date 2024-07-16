using EFT;
using System.Reflection;
using Comfort.Common;
using SPT.Reflection.Patching;

namespace EasySkillOptions.Patches
{
    internal class OnGameStartedPatch : ModulePatch
    {
        protected override MethodBase GetTargetMethod() =>
            typeof(GameWorld).GetMethod(nameof(GameWorld.OnGameStarted), BindingFlags.Public | BindingFlags.Instance);

        [PatchPostfix]
        private static void Postfix(GameWorld __instance)
        {
            Plugin.BackendConfig = Singleton<BackendConfigSettingsClass>.Instance;
            Plugin.SkillManager = __instance.MainPlayer.Skills; 
        }
    }
}

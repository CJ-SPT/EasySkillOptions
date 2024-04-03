using BepInEx.Configuration;
using EFT;
using System.Collections;

namespace EasySkillOptions.Core
{
    internal class EliteSkillToggles
    {
        #region Config Entires

        public static ConfigEntry<bool> instantSearch;
        public static ConfigEntry<bool> eliteAimDrills;
        public static ConfigEntry<bool> eliteAssault;
        public static ConfigEntry<bool> eliteAttention;
        public static ConfigEntry<bool> eliteCharisma;
        public static ConfigEntry<bool> eliteCrafting;
        public static ConfigEntry<bool> eliteCovert;
        public static ConfigEntry<bool> eliteDMR;
        public static ConfigEntry<bool> eliteEndurance;
        public static ConfigEntry<bool> eliteHealth;
        public static ConfigEntry<bool> eliteHeavyVests;
        public static ConfigEntry<bool> eliteHideout;
        public static ConfigEntry<bool> eliteHMG;
        public static ConfigEntry<bool> eliteImmunity;
        public static ConfigEntry<bool> eliteIntellect;
        public static ConfigEntry<bool> eliteLightVests;
        public static ConfigEntry<bool> eliteLMG;
        public static ConfigEntry<bool> eliteMagDrills;
        public static ConfigEntry<bool> eliteMemory;
        public static ConfigEntry<bool> eliteMelee;
        public static ConfigEntry<bool> eliteMetabolism;
        public static ConfigEntry<bool> elitePerception;
        public static ConfigEntry<bool> elitePistol;
        public static ConfigEntry<bool> eliteRecoil;
        public static ConfigEntry<bool> eliteRevolver;
        public static ConfigEntry<bool> eliteSearch;
        public static ConfigEntry<bool> eliteShotgun;
        public static ConfigEntry<bool> eliteSniper;
        public static ConfigEntry<bool> eliteSMG;
        public static ConfigEntry<bool> eliteStrength;
        public static ConfigEntry<bool> eliteStress;
        public static ConfigEntry<bool> eliteSurgery;
        public static ConfigEntry<bool> eliteThrowing;
        public static ConfigEntry<bool> eliteTroubleShooting;
        public static ConfigEntry<bool> eliteVitality;
        public static ConfigEntry<bool> eliteRepair;
        
        #endregion

        #region TOGGLES

        public static void SetToggles()
        {
            InstantSearch();
            EliteAimDrills();
            EliteAssault();
            EliteAttention();
            EliteCharisma();
            EliteCrafting();
            EliteCovert();
            EliteDMR();
            EliteEndurance();
            EliteHealth();
            EliteHeavyVests();
            EliteHideout();
            EliteHMG();
            EliteImmunity();
            EliteIntellect();
            EliteLightVests();
            EliteLMG();
            EliteMagDrills();
            EliteMemory();
            EliteMelee();
            EliteMetabolism();
            ElitePerception();
            ElitePistol();
            EliteRecoil();
            EliteRevolver();
            EliteSearch();
            EliteShotgun();
            EliteSniper();
            EliteSMG();
            EliteStrength();
            EliteStress();
            EliteSurgery();
            EliteThrowing();
            EliteTroubleShooting();
            EliteVitality();
            EliteRepair();
        }
       
        private static void InstantSearch()
        {
            if (!instantSearch.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Search.Level != 51)
            {
                Plugin.SkillManager.Search.SetLevel(51);
            }

            if (Plugin.SkillManager.AttentionEliteExtraLootExp.Value != true)
            {
                Plugin.SkillManager.AttentionEliteExtraLootExp.Value = true;
            }

            if (Plugin.SkillManager.AttentionEliteLuckySearch.Value != 100f)
            {
                Plugin.SkillManager.AttentionEliteLuckySearch.Value = 100f;
            }

            if (Plugin.SkillManager.IntellectEliteContainerScope.Value != true)
            {
                Plugin.SkillManager.IntellectEliteContainerScope.Value = true;
            }
        }

        private static void EliteAimDrills()
        {
            if (!eliteAimDrills.Value)
            {
                return;
            }

            if (Plugin.SkillManager.AimDrills.Level != 51)
            {
                Plugin.SkillManager.AimDrills.SetLevel(51);
            }
        }

        private static void EliteAssault()
        {
            if (!eliteAssault.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Assault.Level != 51)
            {
                Plugin.SkillManager.Assault.SetLevel(51);
            }
        }

        private static void EliteAttention()
        {
            if (!eliteAttention.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Attention.Level != 51)
            {
                Plugin.SkillManager.Attention.SetLevel(51);
            }
        }

        private static void EliteCharisma()
        {
            if (!eliteCharisma.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Charisma.Level != 51)
            {
                Plugin.SkillManager.Charisma.SetLevel(51);
            }
        }

        private static void EliteCrafting(bool bypass = false)
        {
            if (!eliteCrafting.Value || bypass)
            {
                return;
            }

            if (Plugin.SkillManager.Crafting.Level != 51)
            {
                Plugin.SkillManager.Crafting.SetLevel(51);
            }
        }

        private static void EliteCovert()
        {
            if (!eliteCovert.Value)
            {
                return;
            }

            if (Plugin.SkillManager.CovertMovement.Level != 51)
            {
                Plugin.SkillManager.CovertMovement.SetLevel(51);
            }
        }

        private static void EliteDMR()
        {
            if (!eliteDMR.Value)
            {
                return;
            }

            if (Plugin.SkillManager.DMR.Level != 51)
            {
                Plugin.SkillManager.DMR.SetLevel(51);
            }
        }

        private static void EliteEndurance()
        {
            if (!eliteEndurance.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Endurance.Level != 51)
            {
                Plugin.SkillManager.Endurance.SetLevel(51);
            }
        }

        private static void EliteHealth()
        {
            if (!eliteHealth.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Health.Level != 51)
            {
                Plugin.SkillManager.Health.SetLevel(51);
            }
        }

        private static void EliteHeavyVests()
        {
            if (!eliteHeavyVests.Value)
            {
                return;
            }

            if (Plugin.SkillManager.HeavyVests.Level != 51)
            {
                Plugin.SkillManager.HeavyVests.SetLevel(51);
            }
        }

        private static void EliteHideout()
        {
            if (!eliteHideout.Value)
            {
                return;
            }

            if (Plugin.SkillManager.HideoutManagement.Level != 51)
            {
                Plugin.SkillManager.HideoutManagement.SetLevel(51);
            }
        }

        private static void EliteHMG()
        {
            if (!eliteHMG.Value)
            {
                return;
            }

            if (Plugin.SkillManager.HMG.Level != 51)
            {
                Plugin.SkillManager.HMG.SetLevel(51);
            }
        }

        private static void EliteImmunity()
        {
            if (!eliteImmunity.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Immunity.Level != 51)
            {
                Plugin.SkillManager.Immunity.SetLevel(51);
            }
        }

        private static void EliteIntellect()
        {
            if (!eliteIntellect.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Intellect.Level != 51)
            {
                Plugin.SkillManager.Intellect.SetLevel(51);
            }
        }

        private static void EliteLightVests()
        {
            if (!eliteLightVests.Value)
            {
                return;
            }

            if (Plugin.SkillManager.LightVests.Level != 51)
            {
                Plugin.SkillManager.LightVests.SetLevel(51);
            }
        }

        private static void EliteLMG()
        {
            if (!eliteLMG.Value)
            {
                return;
            }

            if (Plugin.SkillManager.LMG.Level != 51)
            {
                Plugin.SkillManager.LMG.SetLevel(51);
            }
        }

        private static void EliteMagDrills()
        {
            if (!eliteMagDrills.Value)
            {
                return;
            }

            if (Plugin.SkillManager.MagDrills.Level != 51)
            {
                Plugin.SkillManager.MagDrills.SetLevel(51);
            }
        }

        private static void EliteMemory()
        {
            if (!eliteMemory.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Memory.Level != 51)
            {
                Plugin.SkillManager.Memory.SetLevel(51);
            }
        }

        private static void EliteMelee()
        {
            if (!eliteMelee.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Melee.Level != 51)
            {
                Plugin.SkillManager.Melee.SetLevel(51);
            }
        }

        private static void EliteMetabolism()
        {
            if (!eliteMetabolism.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Metabolism.Level != 51)
            {
                Plugin.SkillManager.Metabolism.SetLevel(51);
            }
        }

        private static void ElitePerception()
        {
            if (!elitePerception.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Perception.Level != 51)
            {
                Plugin.SkillManager.Perception.SetLevel(51);
            }
        }

        private static void ElitePistol()
        {
            if (!elitePistol.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Pistol.Level != 51)
            {
                Plugin.SkillManager.Pistol.SetLevel(51);
            }
        }

        private static void EliteRecoil()
        {
            if (!eliteRecoil.Value)
            {
                return;
            }

            if (Plugin.SkillManager.RecoilControl.Level != 51)
            {
                Plugin.SkillManager.RecoilControl.SetLevel(51);
            }
        }

        private static void EliteRevolver()
        {
            if (!eliteRevolver.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Revolver.Level != 51)
            {
                Plugin.SkillManager.Revolver.SetLevel(51);
            }
        }

        private static void EliteSearch()
        {
            if (!eliteSearch.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Search.Level != 51)
            {
                Plugin.SkillManager.Search.SetLevel(51);
            }
        }

        private static void EliteShotgun()
        {
            if (!eliteShotgun.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Shotgun.Level != 51)
            {
                Plugin.SkillManager.Shotgun.SetLevel(51);
            }
        }

        private static void EliteSniper()
        {
            if (!eliteSniper.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Sniper.Level != 51)
            {
                Plugin.SkillManager.Sniper.SetLevel(51);
            }
        }

        private static void EliteSMG()
        {
            if (!eliteSMG.Value)
            {
                return;
            }

            if (Plugin.SkillManager.SMG.Level != 51)
            {
                Plugin.SkillManager.SMG.SetLevel(51);
            }
        }

        private static void EliteStrength()
        {
            if (!eliteStrength.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Strength.Level != 51)
            {
                Plugin.SkillManager.Strength.SetLevel(51);
            }
        }

        private static void EliteStress()
        {
            if (!eliteStress.Value)
            {
                return;
            }

            if (Plugin.SkillManager.StressResistance.Level != 51)
            {
                Plugin.SkillManager.StressResistance.SetLevel(51);
            }
        }

        private static void EliteSurgery()
        {
            if (!eliteSurgery.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Surgery.Level != 51)
            {
                Plugin.SkillManager.Surgery.SetLevel(51);
            }
        }

        private static void EliteThrowing()
        {
            if (!eliteThrowing.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Throwing.Level != 51)
            {
                Plugin.SkillManager.Throwing.SetLevel(51);
            }
        }

        private static void EliteTroubleShooting()
        {
            if (!eliteTroubleShooting.Value)
            {
                return;
            }

            if (Plugin.SkillManager.TroubleShooting.Level != 51)
            {
                Plugin.SkillManager.TroubleShooting.SetLevel(51);
            }
        }

        private static void EliteVitality()
        {
            if (!eliteVitality.Value)
            {
                return;
            }

            if (Plugin.SkillManager.Vitality.Level != 51)
            {
                Plugin.SkillManager.Vitality.SetLevel(51);
            }
        }

        private static void EliteRepair()
        {
            if (!eliteRepair.Value)
            {
                return;
            }

            if (Plugin.SkillManager.WeaponTreatment.Level != 51)
            {
                Plugin.SkillManager.WeaponTreatment.SetLevel(51);
            }
        }

        #endregion

        public static void RegisterConfig(ConfigFile Config)
        {
            string mainSectionElite = "Easy Skill Options - Elite Toggles";

            instantSearch = Config.Bind(
               "General",
               "Instant Search",
               false,
               "Instantly search containers");

            eliteAimDrills = Config.Bind(
               mainSectionElite,
               "Toggle Elite AimDrills",
               false,
               "Enables elite AimDrills");

            eliteAssault = Config.Bind(
               mainSectionElite,
               "Toggle Elite Assault",
               false,
               "Enables elite Assault");

            eliteAttention = Config.Bind(
              mainSectionElite,
              "Toggle Elite Attention",
              false,
              "Enables elite Attention");

            eliteCharisma = Config.Bind(
               mainSectionElite,
               "Toggle Elite Charisma",
               false,
               "Enables elite Charisma");

            eliteCrafting = Config.Bind(
               mainSectionElite,
               "Toggle Elite Crafting",
               false,
               "Enables elite Crafting");

            eliteCovert = Config.Bind(
               mainSectionElite,
               "Toggle Elite Covert movement",
               false,
               "Enables elite Covert movement");

            eliteDMR = Config.Bind(
               mainSectionElite,
               "Toggle Elite DMR",
               false,
               "Enables elite DMR");

            eliteEndurance = Config.Bind(
               mainSectionElite,
               "Toggle Elite Endurance",
               false,
               "Enables elite Endurance");

            eliteHealth = Config.Bind(
              mainSectionElite,
              "Toggle Elite Health",
              false,
              "Enables elite Health");

            eliteHeavyVests = Config.Bind(
              mainSectionElite,
              "Toggle Elite Heavy Vests",
              false,
              "Enables elite Heavy Vests");

            eliteHideout = Config.Bind(
              mainSectionElite,
              "Toggle Elite Hideout management",
              false,
              "Enables Hideout management");

            eliteHMG = Config.Bind(
              mainSectionElite,
              "Toggle Elite HMGs",
              false,
              "Enables elite HMGs");

            eliteImmunity = Config.Bind(
               mainSectionElite,
               "Toggle Elite Immunity",
               false,
               "Enables elite Immunity");

            eliteIntellect = Config.Bind(
              mainSectionElite,
              "Toggle Elite Intellect",
              false,
              "Enables elite Intellect");

            eliteLightVests = Config.Bind(
              mainSectionElite,
              "Toggle Elite Light Vests",
              false,
              "Enables elite Light Vests");

            eliteLMG = Config.Bind(
              mainSectionElite,
              "Toggle Elite LMGs",
              false,
              "Enables elite LMGs");

            eliteMagDrills = Config.Bind(
               mainSectionElite,
               "Toggle Elite MagDrills",
               false,
               "Enables elite MagDrills");

            eliteMemory = Config.Bind(
              mainSectionElite,
              "Toggle Elite Memory",
              false,
              "Enables elite Memory");

            eliteMetabolism = Config.Bind(
              mainSectionElite,
              "Toggle Elite Metabolism",
              false,
              "Enables elite Metabolism");

            eliteMelee = Config.Bind(
              mainSectionElite,
              "Toggle Elite Melee",
              false,
              "Enables elite Melee");

            elitePerception = Config.Bind(
               mainSectionElite,
               "Toggle Elite Perception",
               false,
               "Enables elite Perception");

            elitePistol = Config.Bind(
               mainSectionElite,
               "Toggle Elite Pistols",
               false,
               "Enables elite Pistols");

            eliteRecoil = Config.Bind(
              mainSectionElite,
              "Toggle Elite Recoil Control",
              false,
              "Enables elite Recoil Control");

            eliteRevolver = Config.Bind(
              mainSectionElite,
              "Toggle Elite Revolvers",
              false,
              "Enables elite Revolvers");

            eliteSearch = Config.Bind(
               mainSectionElite,
               "Toggle Elite Search",
               false,
               "Enables elite Search (search two containers at once)");

            eliteShotgun = Config.Bind(
              mainSectionElite,
              "Toggle Elite Shotguns",
              false,
              "Enables elite Shotguns");

            eliteSniper = Config.Bind(
               mainSectionElite,
               "Toggle Elite Snipers",
               false,
               "Enables elite Snipers");

            eliteSMG = Config.Bind(
               mainSectionElite,
               "Toggle Elite SMGs",
               false,
               "Enables elite SMGs");

            eliteStrength = Config.Bind(
              mainSectionElite,
              "Toggle Elite Strength",
              false,
              "Enables elite Strength");

            eliteStress = Config.Bind(
              mainSectionElite,
              "Toggle Elite Stress",
              false,
              "Enables elite Stress");

            eliteSurgery = Config.Bind(
              mainSectionElite,
              "Toggle Elite Surgery",
              false,
              "Enables elite Surgery");

            eliteThrowing = Config.Bind(
              mainSectionElite,
              "Toggle Elite Throwing",
              false,
              "Enables elite Throwing");

            eliteTroubleShooting = Config.Bind(
              mainSectionElite,
              "Toggle Elite Troubleshooting",
              false,
              "Enables elite Troubleshooting");

            eliteVitality = Config.Bind(
              mainSectionElite,
              "Toggle Elite Vitality",
              false,
              "Enables elite Vitality");

            eliteRepair = Config.Bind(
              mainSectionElite,
              "Toggle Elite Weapon Maintenance",
              false,
              "Enables elite Weapon Maintenance");
        }
    }
}
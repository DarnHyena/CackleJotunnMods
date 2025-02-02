﻿using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Cackleheim
{   
    public class CackleMountain
    {

        private static GameObject WHatObj;
        private static GameObject WPantObj;
        private static GameObject WCapeObj;
        private static GameObject WChestObj;

        private static GameObject CuPantObj;
        private static GameObject CuChestObj;
        private static GameObject CuHatObj;

        private static Texture2D TunicTex;


        public static void AddCackleMountain()
        {
            //========ASSETBUNDLES========// 

            AssetBundle MountainBundle = AssetUtils.LoadAssetBundleFromResources("itemmountain", typeof(CackleMountain).Assembly);
            WHatObj = MountainBundle.LoadAsset<GameObject>("chWoHelm");
            WPantObj = MountainBundle.LoadAsset<GameObject>("chWoPants");
            WCapeObj = MountainBundle.LoadAsset<GameObject>("chWoVest");
            WChestObj = MountainBundle.LoadAsset<GameObject>("chWoCloak");

            CuPantObj = MountainBundle.LoadAsset<GameObject>("chCuSuit");
            CuHatObj = MountainBundle.LoadAsset<GameObject>("chCuMask");
            CuChestObj = MountainBundle.LoadAsset<GameObject>("chCuTunic");
            TunicTex = MountainBundle.LoadAsset<Texture2D>("CultTunics");

            MountainBundle.Unload(false);

            //==========WOLF==========//

            CustomItem WhatItem = new CustomItem(WHatObj, true, new ItemConfig()
            {
                CraftingStation = "forge", 
                MinStationLevel = 1,  
                Requirements = new RequirementConfig[]
                {
                    new RequirementConfig()
                    {
                        Item = "TrophyWolf",
                        Amount = 5,
                        AmountPerLevel = 0
                    },
                    new RequirementConfig()
                    {
                        Item = "WolfPelt",
                        Amount = 2,
                        AmountPerLevel = 0
                    },
                    new RequirementConfig()
                    {
                        Item = "Silver",
                        Amount = 20,
                        AmountPerLevel = 5
                    }
                }
            });
            ItemManager.Instance.AddItem(WhatItem);

            CustomItem WcapeItem = new CustomItem(WCapeObj, true, new ItemConfig()
            {
                CraftingStation = "piece_workbench",
                MinStationLevel = 2,
                Requirements = new RequirementConfig[]
                {
                    new RequirementConfig()
                    {
                        Item = "TrophyWolf",
                        Amount = 1,
                        AmountPerLevel = 0
                    },
                    new RequirementConfig()
                    {
                        Item = "WolfPelt",
                        Amount = 6,
                        AmountPerLevel = 4
                    },
                    new RequirementConfig()
                    {
                        Item = "Silver",
                        Amount = 4,
                        AmountPerLevel = 2
                    }
                }
            });
            ItemManager.Instance.AddItem(WcapeItem);

            CustomItem WpantItem = new CustomItem(WPantObj, true, new ItemConfig()
            {
                CraftingStation = "forge",
                MinStationLevel = 2,
                Requirements = new RequirementConfig[]
    {
                    new RequirementConfig()
                    {
                        Item = "WolfFang",
                        Amount = 4,
                        AmountPerLevel = 1
                    },
                    new RequirementConfig()
                    {
                        Item = "WolfPelt",
                        Amount = 5,
                        AmountPerLevel = 2
                    },
                    new RequirementConfig()
                    {
                        Item = "Silver",
                        Amount = 20,
                        AmountPerLevel = 5
                    }
                }
            });
            ItemManager.Instance.AddItem(WpantItem);

            CustomItem WchestItem = new CustomItem(WChestObj, true, new ItemConfig()
            {
                CraftingStation = "forge",
                MinStationLevel = 2,
                Requirements = new RequirementConfig[]
    {
                    new RequirementConfig()
                    {
                        Item = "Chain",
                        Amount = 1,
                        AmountPerLevel = 0
                    },
                    new RequirementConfig()
                    {
                        Item = "WolfPelt",
                        Amount = 5,
                        AmountPerLevel = 2
                    },
                    new RequirementConfig()
                    {
                        Item = "Silver",
                        Amount = 20,
                        AmountPerLevel = 5
                    }
                }
            });
            ItemManager.Instance.AddItem(WchestItem);

            //==========CAVE==========//

            CustomItem CuhatItem = new CustomItem(CuHatObj, true, new ItemConfig()
            {
                CraftingStation = "piece_workbench",
                MinStationLevel = 2,
                Requirements = new RequirementConfig[]
    {
                    new RequirementConfig()
                    {
                        Item = "TrophyCultist",
                        Amount = 1,
                        AmountPerLevel = 0
                    },
                    new RequirementConfig()
                    {
                        Item = "WolfPelt",
                        Amount = 2,
                        AmountPerLevel = 4
                    },
                    new RequirementConfig()
                    {
                        Item = "WolfHairBundle",
                        Amount = 20,
                        AmountPerLevel = 5
                    }
                }
            });
            ItemManager.Instance.AddItem(CuhatItem);

            CustomItem CupantItem = new CustomItem(CuPantObj, true, new ItemConfig()
            {
                CraftingStation = "piece_workbench",
                MinStationLevel = 2,
                Requirements = new RequirementConfig[]
    {
                    new RequirementConfig()
                    {
                        Item = "LeatherScraps",
                        Amount = 10,
                        AmountPerLevel = 4
                    },
                    new RequirementConfig()
                    {
                        Item = "WolfPelt",
                        Amount = 5,
                        AmountPerLevel = 3
                    },
                    new RequirementConfig()
                    {
                        Item = "WolfHairBundle",
                        Amount = 20,
                        AmountPerLevel = 5
                    }
                }
            });
            ItemManager.Instance.AddItem(CupantItem);

            CustomItem CuchestItem = new CustomItem(CuChestObj, true, new ItemConfig()
            {
                CraftingStation = "piece_workbench",
                MinStationLevel = 2,
                StyleTex = TunicTex,

                Requirements = new RequirementConfig[]
    {
                    new RequirementConfig()
                    {
                        Item = "LeatherScraps",
                        Amount = 10,
                        AmountPerLevel = 4
                    },
                    new RequirementConfig()
                    {
                        Item = "WolfPelt",
                        Amount = 5,
                        AmountPerLevel = 3
                    },
                    new RequirementConfig()
                    {
                        Item = "WolfHairBundle",
                        Amount = 20,
                        AmountPerLevel = 5
                    }
                }
            });
            ItemManager.Instance.AddItem(CuchestItem);

            //===Item Names, Description===//
            //========&Localization========//

            var localization = LocalizationManager.Instance.GetLocalization();
            localization.AddTranslation("English", new Dictionary<string, string>
            {
                    {"chWH", "[CH]Wolf Helm" },
                    {"chWC", "[CH]Wolf Cloak" },
                    {"chWV", "[CH]Wolf Vest" },
                    {"chWP", "[CH]Wolf Pants" },
                    {"chWH_D", "Wolf skull lined with fur to keep your own skull from turning into a numb skull"},
                    {"chWC_D", "Bulky heavy fur scarf for those hardened adventurers in the mountains"},
                    {"chWV_D", "Dashing little furred vest to help new explorers ward off the cold"},
                    {"chWP_D", "Yet another pair of pants"},

                    {"chCM", "[CH]Cultist Mask" },
                    {"chCT", "[CH]Cultist Tunic" },
                    {"chCS", "[CH]Cultist Suit" },
                    {"chCM_D", "Mask of The Bah"},
                    {"chCT_D", "One day a fallen tree left a hole in a canopy and a new fashion trend was born."},
                    {"chCS_D", "Plaid pants are always in style"},

            });
        }
    }
}
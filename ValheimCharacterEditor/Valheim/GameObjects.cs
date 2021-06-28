using System.Collections.Generic;

namespace ValheimCharacterEditor.Valheim
{
    public class GameObjects
    {
        public static readonly Dictionary<string, GameObjectProperties> ItemProperties =
            new Dictionary<string, GameObjectProperties>()
            {
                {
                    "Amber",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Amber)
                },
                {
                    "AmberPearl",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.AmberPearl)
                },
                {
                    "AncientSeed",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.AncientSeed)
                },
                {
                    "ArmorBronzeChest",
                    new GameObjectProperties(1, 4, 0, 1000, 200, true,
                        ValheimCharacterEditor.Properties.Resources.ArmorBronzeChest)
                },
                {
                    "ArmorBronzeLegs",
                    new GameObjectProperties(1, 4, 0, 1000, 200, true,
                        ValheimCharacterEditor.Properties.Resources.ArmorBronzeLegs)
                },
                {
                    "ArmorIronChest",
                    new GameObjectProperties(1, 4, 0, 1000, 200, true,
                        ValheimCharacterEditor.Properties.Resources.ArmorIronChest)
                },
                {
                    "ArmorIronLegs",
                    new GameObjectProperties(1, 4, 0, 1000, 200, true,
                        ValheimCharacterEditor.Properties.Resources.ArmorIronLegs)
                },
                {
                    "ArmorLeatherChest",
                    new GameObjectProperties(1, 4, 0, 400, 100, true,
                        ValheimCharacterEditor.Properties.Resources.ArmorLeatherChest)
                },
                {
                    "ArmorLeatherLegs",
                    new GameObjectProperties(1, 4, 0, 400, 100, true,
                        ValheimCharacterEditor.Properties.Resources.ArmorLeatherLegs)
                },
                {
                    "ArmorPaddedCuirass",
                    new GameObjectProperties(1, 4, 0, 1000, 200, true,
                        ValheimCharacterEditor.Properties.Resources.ArmorPaddedCuirass)
                },
                {
                    "ArmorPaddedGreaves",
                    new GameObjectProperties(1, 4, 0, 1000, 200, true,
                        ValheimCharacterEditor.Properties.Resources.ArmorPaddedGreaves)
                },
                {
                    "ArmorRagsChest",
                    new GameObjectProperties(1, 2, 0, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ArmorRagsChest)
                },
                {
                    "ArmorRagsLegs",
                    new GameObjectProperties(1, 2, 0, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ArmorRagsLegs)
                },
                {
                    "ArmorTrollLeatherChest",
                    new GameObjectProperties(1, 4, 0, 500, 200, true,
                        ValheimCharacterEditor.Properties.Resources.ArmorTrollLeatherChest)
                },
                {
                    "ArmorTrollLeatherLegs",
                    new GameObjectProperties(1, 4, 0, 500, 200, true,
                        ValheimCharacterEditor.Properties.Resources.ArmorTrollLeatherLegs)
                },
                {
                    "ArmorWolfChest",
                    new GameObjectProperties(1, 4, 0, 1000, 200, true,
                        ValheimCharacterEditor.Properties.Resources.ArmorWolfChest)
                },
                {
                    "ArmorWolfLegs",
                    new GameObjectProperties(1, 4, 0, 1000, 200, true,
                        ValheimCharacterEditor.Properties.Resources.ArmorWolfLegs)
                },
                {
                    "ArrowBronze",
                    new GameObjectProperties(100, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ArrowBronze)
                },
                {
                    "ArrowFire",
                    new GameObjectProperties(100, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ArrowFire)
                },
                {
                    "ArrowFlint",
                    new GameObjectProperties(100, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ArrowFlint)
                },
                {
                    "ArrowFrost",
                    new GameObjectProperties(100, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ArrowFrost)
                },
                {
                    "ArrowIron",
                    new GameObjectProperties(100, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ArrowIron)
                },
                {
                    "ArrowNeedle",
                    new GameObjectProperties(100, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ArrowNeedle)
                },
                {
                    "ArrowObsidian",
                    new GameObjectProperties(100, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ArrowObsidian)
                },
                {
                    "ArrowPoison",
                    new GameObjectProperties(100, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ArrowPoison)
                },
                {
                    "ArrowSilver",
                    new GameObjectProperties(100, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ArrowSilver)
                },
                {
                    "ArrowWood",
                    new GameObjectProperties(100, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ArrowWood)
                },
                {
                    "AtgeirBlackmetal",
                    new GameObjectProperties(1, 4, 0, 175, 50, true,
                        ValheimCharacterEditor.Properties.Resources.AtgeirBlackmetal)
                },
                {
                    "AtgeirBronze",
                    new GameObjectProperties(1, 4, 0, 125, 50, true,
                        ValheimCharacterEditor.Properties.Resources.AtgeirBronze)
                },
                {
                    "AtgeirIron",
                    new GameObjectProperties(1, 4, 0, 175, 50, true,
                        ValheimCharacterEditor.Properties.Resources.AtgeirIron)
                },
                {
                    "AxeBlackMetal",
                    new GameObjectProperties(1, 4, 0, 175, 50, true,
                        ValheimCharacterEditor.Properties.Resources.AxeBlackMetal)
                },
                {
                    "AxeBronze",
                    new GameObjectProperties(1, 4, 0, 125, 50, true,
                        ValheimCharacterEditor.Properties.Resources.AxeBronze)
                },
                {
                    "AxeFlint",
                    new GameObjectProperties(1, 4, 0, 100, 30, true,
                        ValheimCharacterEditor.Properties.Resources.AxeFlint)
                },
                {
                    "AxeIron",
                    new GameObjectProperties(1, 4, 0, 175, 50, true,
                        ValheimCharacterEditor.Properties.Resources.AxeIron)
                },
                {
                    "AxeStone",
                    new GameObjectProperties(1, 4, 0, 100, 30, true,
                        ValheimCharacterEditor.Properties.Resources.AxeStone)
                },
                {
                    "Barley",
                    new GameObjectProperties(100, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.Barley)
                },
                {
                    "BarleyFlour",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.BarleyFlour)
                },
                {
                    "BarleyWine",
                    new GameObjectProperties(10, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.BarleyWine)
                },
                {
                    "BarleyWineBase",
                    new GameObjectProperties(1, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.BarleyWineBase)
                },
                {
                    "Battleaxe",
                    new GameObjectProperties(1, 4, 0, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.Battleaxe)
                },
                {
                    "Beard1",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Beard1)
                },
                {
                    "Beard10",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Beard10)
                },
                {
                    "Beard2",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Beard2)
                },
                {
                    "Beard3",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Beard3)
                },
                {
                    "Beard4",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Beard4)
                },
                {
                    "Beard5",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Beard5)
                },
                {
                    "Beard6",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Beard6)
                },
                {
                    "Beard7",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Beard7)
                },
                {
                    "Beard8",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Beard8)
                },
                {
                    "Beard9",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Beard9)
                },
                {
                    "BeardNone",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.BeardNone)
                },
                {
                    "BeechSeeds",
                    new GameObjectProperties(100, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.BeechSeeds)
                },
                {
                    "BeltStrength",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.BeltStrength)
                },
                {
                    "BlackMetal",
                    new GameObjectProperties(30, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.BlackMetal)
                },
                {
                    "BlackMetalScrap",
                    new GameObjectProperties(30, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.BlackMetalScrap)
                },
                {
                    "blobelite_attack_aoe",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.blobelite_attack_aoe)
                },
                {
                    "blob_attack_aoe",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.blob_attack_aoe)
                },
                {
                    "Bloodbag",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Bloodbag)
                },
                {
                    "BloodPudding",
                    new GameObjectProperties(10, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.BloodPudding)
                },
                {
                    "Blueberries",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Blueberries)
                },
                {
                    "boar_base_attack",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.boar_base_attack)
                },
                {
                    "BombOoze",
                    new GameObjectProperties(50, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.BombOoze)
                },
                {
                    "BoneFragments",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.BoneFragments)
                },
                {
                    "bonemass_attack_aoe",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.bonemass_attack_aoe)
                },
                {
                    "bonemass_attack_punch",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.bonemass_attack_punch)
                },
                {
                    "bonemass_attack_spawn",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.bonemass_attack_spawn)
                },
                {
                    "bonemass_attack_throw",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.bonemass_attack_throw)
                },
                {
                    "Bow",
                    new GameObjectProperties(1, 4, 0, 50, 50, true, ValheimCharacterEditor.Properties.Resources.Bow)
                },
                {
                    "BowDraugrFang",
                    new GameObjectProperties(1, 4, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.BowDraugrFang)
                },
                {
                    "BowFineWood",
                    new GameObjectProperties(1, 4, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.BowFineWood)
                },
                {
                    "BowHuntsman",
                    new GameObjectProperties(1, 4, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.BowHuntsman)
                },
                {
                    "Bread",
                    new GameObjectProperties(20, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.Bread)
                },
                {
                    "Bronze",
                    new GameObjectProperties(30, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.Bronze)
                },
                {
                    "BronzeNails",
                    new GameObjectProperties(100, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.BronzeNails)
                },
                {
                    "CapeDeerHide",
                    new GameObjectProperties(1, 4, 0, 400, 50, true,
                        ValheimCharacterEditor.Properties.Resources.CapeDeerHide)
                },
                {
                    "CapeLinen",
                    new GameObjectProperties(1, 4, 6, 1500, 50, true,
                        ValheimCharacterEditor.Properties.Resources.CapeLinen)
                },
                {
                    "CapeLox",
                    new GameObjectProperties(1, 4, 0, 1200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.CapeLox)
                },
                {
                    "CapeOdin",
                    new GameObjectProperties(1, 4, 1, 1500, 50, true,
                        ValheimCharacterEditor.Properties.Resources.CapeOdin)
                },
                {
                    "CapeTest",
                    new GameObjectProperties(1, 4, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.CapeTest)
                },
                {
                    "CapeTrollHide",
                    new GameObjectProperties(1, 4, 0, 500, 50, true,
                        ValheimCharacterEditor.Properties.Resources.CapeTrollHide)
                },
                {
                    "CapeWolf",
                    new GameObjectProperties(1, 4, 0, 1000, 200, true,
                        ValheimCharacterEditor.Properties.Resources.CapeWolf)
                },
                {
                    "Carrot",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Carrot)
                },
                {
                    "CarrotSeeds",
                    new GameObjectProperties(100, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.CarrotSeeds)
                },
                {
                    "CarrotSoup",
                    new GameObjectProperties(10, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.CarrotSoup)
                },
                {
                    "Chain",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Chain)
                },
                {
                    "Chitin",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Chitin)
                },
                {
                    "Cloudberry",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Cloudberry)
                },
                {
                    "Club",
                    new GameObjectProperties(1, 4, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.Club)
                },
                {
                    "Coal",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Coal)
                },
                {
                    "Coins",
                    new GameObjectProperties(999, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Coins)
                },
                {
                    "CookedLoxMeat",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.CookedLoxMeat)
                },
                {
                    "CookedMeat",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.CookedMeat)
                },
                {
                    "Copper",
                    new GameObjectProperties(30, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Copper)
                },
                {
                    "CopperOre",
                    new GameObjectProperties(30, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.CopperOre)
                },
                {
                    "CryptKey",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.CryptKey)
                },
                {
                    "Crystal",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Crystal)
                },
                {
                    "Cultivator",
                    new GameObjectProperties(1, 3, 0, 200, 200, true,
                        ValheimCharacterEditor.Properties.Resources.Cultivator)
                },
                {
                    "Dandelion",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Dandelion)
                },
                {
                    "Deathsquito_sting",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Deathsquito_sting)
                },
                {
                    "DeerHide",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.DeerHide)
                },
                {
                    "DragonEgg",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.DragonEgg)
                },
                {
                    "DragonTear",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.DragonTear)
                },
                {
                    "dragon_bite",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.dragon_bite)
                },
                {
                    "dragon_claw_left",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.dragon_claw_left)
                },
                {
                    "dragon_claw_right",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.dragon_claw_right)
                },
                {
                    "dragon_coldbreath",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.dragon_coldbreath)
                },
                {
                    "dragon_coldbreath_OLD",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.dragon_coldbreath_OLD)
                },
                {
                    "dragon_spit_shotgun",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.dragon_spit_shotgun)
                },
                {
                    "dragon_taunt",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.dragon_taunt)
                },
                {
                    "draugr_arrow",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.draugr_arrow)
                },
                {
                    "draugr_axe",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.draugr_axe)
                },
                {
                    "draugr_bow",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.draugr_bow)
                },
                {
                    "draugr_sword",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.draugr_sword)
                },
                {
                    "Eikthyr_antler",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Eikthyr_antler)
                },
                {
                    "Eikthyr_charge",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Eikthyr_charge)
                },
                {
                    "Eikthyr_flegs_OLD",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Eikthyr_flegs_OLD)
                },
                {
                    "Eikthyr_stomp",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Eikthyr_stomp)
                },
                {
                    "ElderBark",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.ElderBark)
                },
                {
                    "Entrails",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Entrails)
                },
                {
                    "Feathers",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Feathers)
                },
                {
                    "Fenring_attack_claw",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Fenring_attack_claw)
                },
                {
                    "Fenring_attack_jump",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Fenring_attack_jump)
                },
                {
                    "Fenring_taunt",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Fenring_taunt)
                },
                {
                    "FineWood",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.FineWood)
                },
                {
                    "FirCone",
                    new GameObjectProperties(100, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.FirCone)
                },
                {
                    "FishCooked",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.FishCooked)
                },
                {
                    "FishingBait",
                    new GameObjectProperties(100, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.FishingBait)
                },
                {
                    "FishingRod",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.FishingRod)
                },
                {
                    "FishRaw",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.FishRaw)
                },
                {
                    "FishWraps",
                    new GameObjectProperties(10, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.FishWraps)
                },
                {
                    "Flametal",
                    new GameObjectProperties(30, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Flametal)
                },
                {
                    "FlametalOre",
                    new GameObjectProperties(30, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.FlametalOre)
                },
                {
                    "Flax",
                    new GameObjectProperties(100, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Flax)
                },
                {
                    "Flint",
                    new GameObjectProperties(30, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Flint)
                },
                {
                    "FreezeGland",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.FreezeGland)
                },
                {
                    "gd_king_punch",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.gd_king_punch)
                },
                {
                    "gd_king_rootspawn",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.gd_king_rootspawn)
                },
                {
                    "gd_king_scream",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.gd_king_scream)
                },
                {
                    "gd_king_shoot",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.gd_king_shoot)
                },
                {
                    "gd_king_stomp",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.gd_king_stomp)
                },
                {
                    "Ghost_attack",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Ghost_attack)
                },
                {
                    "GoblinArmband",
                    new GameObjectProperties(1, 4, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinArmband)
                },
                {
                    "GoblinBrute_ArmGuard",
                    new GameObjectProperties(1, 4, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinBrute_ArmGuard)
                },
                {
                    "GoblinBrute_Attack",
                    new GameObjectProperties(1, 7, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinBrute_Attack)
                },
                {
                    "GoblinBrute_Backbones",
                    new GameObjectProperties(1, 4, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinBrute_Backbones)
                },
                {
                    "GoblinBrute_ExecutionerCap",
                    new GameObjectProperties(1, 4, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinBrute_ExecutionerCap)
                },
                {
                    "GoblinBrute_HipCloth",
                    new GameObjectProperties(1, 4, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinBrute_HipCloth)
                },
                {
                    "GoblinBrute_LegBones",
                    new GameObjectProperties(1, 4, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinBrute_LegBones)
                },
                {
                    "GoblinBrute_RageAttack",
                    new GameObjectProperties(1, 7, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinBrute_RageAttack)
                },
                {
                    "GoblinBrute_ShoulderGuard",
                    new GameObjectProperties(1, 4, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinBrute_ShoulderGuard)
                },
                {
                    "GoblinBrute_Taunt",
                    new GameObjectProperties(1, 7, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinBrute_Taunt)
                },
                {
                    "GoblinClub",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinClub)
                },
                {
                    "GoblinHelmet",
                    new GameObjectProperties(1, 4, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinHelmet)
                },
                {
                    "GoblinKing_Beam",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinKing_Beam)
                },
                {
                    "GoblinKing_Meteors",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinKing_Meteors)
                },
                {
                    "GoblinKing_Nova",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinKing_Nova)
                },
                {
                    "GoblinKing_Taunt",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinKing_Taunt)
                },
                {
                    "GoblinLegband",
                    new GameObjectProperties(1, 4, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinLegband)
                },
                {
                    "GoblinLoin",
                    new GameObjectProperties(1, 4, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinLoin)
                },
                {
                    "GoblinShaman_attack_fireball",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinShaman_attack_fireball)
                },
                {
                    "GoblinShaman_attack_poke",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinShaman_attack_poke)
                },
                {
                    "GoblinShaman_attack_protect",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinShaman_attack_protect)
                },
                {
                    "GoblinShaman_Headdress_antlers",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinShaman_Headdress_antlers)
                },
                {
                    "GoblinShaman_Headdress_feathers",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinShaman_Headdress_feathers)
                },
                {
                    "GoblinShaman_Staff_Bones",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinShaman_Staff_Bones)
                },
                {
                    "GoblinShaman_Staff_Feathers",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinShaman_Staff_Feathers)
                },
                {
                    "GoblinShoulders",
                    new GameObjectProperties(1, 4, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinShoulders)
                },
                {
                    "GoblinSpear",
                    new GameObjectProperties(10, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinSpear)
                },
                {
                    "GoblinSword",
                    new GameObjectProperties(1, 7, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinSword)
                },
                {
                    "GoblinTorch",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinTorch)
                },
                {
                    "GoblinTotem",
                    new GameObjectProperties(30, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GoblinTotem)
                },
                {
                    "GreydwarfEye",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.GreydwarfEye)
                },
                {
                    "Greydwarf_attack",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Greydwarf_attack)
                },
                {
                    "Greydwarf_elite_attack",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Greydwarf_elite_attack)
                },
                {
                    "Greydwarf_shaman_attack",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Greydwarf_shaman_attack)
                },
                {
                    "Greydwarf_shaman_heal",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Greydwarf_shaman_heal)
                },
                {
                    "Greydwarf_throw",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Greydwarf_throw)
                },
                {
                    "Greyling_attack",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Greyling_attack)
                },
                {
                    "Guck",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Guck)
                },
                {
                    "Hair1",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Hair1)
                },
                {
                    "Hair10",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Hair10)
                },
                {
                    "Hair11",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Hair11)
                },
                {
                    "Hair12",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Hair12)
                },
                {
                    "Hair13",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Hair13)
                },
                {
                    "Hair14",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Hair14)
                },
                {
                    "Hair2",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Hair2)
                },
                {
                    "Hair3",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Hair3)
                },
                {
                    "Hair4",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Hair4)
                },
                {
                    "Hair5",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Hair5)
                },
                {
                    "Hair6",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Hair6)
                },
                {
                    "Hair7",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Hair7)
                },
                {
                    "Hair8",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Hair8)
                },
                {
                    "Hair9",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Hair9)
                },
                {
                    "HairNone",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.HairNone)
                },
                {
                    "Hammer",
                    new GameObjectProperties(1, 3, 0, 100, 100, true,
                        ValheimCharacterEditor.Properties.Resources.Hammer)
                },
                {
                    "HardAntler",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.HardAntler)
                },
                {
                    "hatchling_spit_cold",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.hatchling_spit_cold)
                },
                {
                    "HealthUpgrade_Bonemass",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.HealthUpgrade_Bonemass)
                },
                {
                    "HealthUpgrade_GDKing",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.HealthUpgrade_GDKing)
                },
                {
                    "HelmetBronze",
                    new GameObjectProperties(1, 4, 0, 1000, 200, true,
                        ValheimCharacterEditor.Properties.Resources.HelmetBronze)
                },
                {
                    "HelmetDrake",
                    new GameObjectProperties(1, 4, 0, 1000, 200, true,
                        ValheimCharacterEditor.Properties.Resources.HelmetDrake)
                },
                {
                    "HelmetDverger",
                    new GameObjectProperties(1, 1, 0, 1000, 100, true,
                        ValheimCharacterEditor.Properties.Resources.HelmetDverger)
                },
                {
                    "HelmetIron",
                    new GameObjectProperties(1, 4, 0, 1000, 200, true,
                        ValheimCharacterEditor.Properties.Resources.HelmetIron)
                },
                {
                    "HelmetLeather",
                    new GameObjectProperties(1, 4, 0, 400, 100, true,
                        ValheimCharacterEditor.Properties.Resources.HelmetLeather)
                },
                {
                    "HelmetOdin",
                    new GameObjectProperties(1, 4, 0, 300, 100, true,
                        ValheimCharacterEditor.Properties.Resources.HelmetOdin)
                },
                {
                    "HelmetPadded",
                    new GameObjectProperties(1, 4, 0, 1000, 200, true,
                        ValheimCharacterEditor.Properties.Resources.HelmetPadded)
                },
                {
                    "HelmetTrollLeather",
                    new GameObjectProperties(1, 4, 0, 500, 200, true,
                        ValheimCharacterEditor.Properties.Resources.HelmetTrollLeather)
                },
                {
                    "HelmetYule",
                    new GameObjectProperties(1, 1, 0, 1000, 50, false,
                        ValheimCharacterEditor.Properties.Resources.HelmetYule)
                },
                {
                    "Hoe",
                    new GameObjectProperties(1, 3, 0, 200, 200, true,
                        ValheimCharacterEditor.Properties.Resources.Hoe)
                },
                {
                    "Honey",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Honey)
                },
                {
                    "imp_fireball_attack",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.imp_fireball_attack)
                },
                {
                    "Iron",
                    new GameObjectProperties(30, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Iron)
                },
                {
                    "IronNails",
                    new GameObjectProperties(100, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.IronNails)
                },
                {
                    "IronOre",
                    new GameObjectProperties(30, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.IronOre)
                },
                {
                    "IronScrap",
                    new GameObjectProperties(30, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.IronScrap)
                },
                {
                    "KnifeBlackMetal",
                    new GameObjectProperties(1, 4, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.KnifeBlackMetal)
                },
                {
                    "KnifeChitin",
                    new GameObjectProperties(1, 4, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.KnifeChitin)
                },
                {
                    "KnifeCopper",
                    new GameObjectProperties(1, 4, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.KnifeCopper)
                },
                {
                    "KnifeFlint",
                    new GameObjectProperties(1, 4, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.KnifeFlint)
                },
                {
                    "LeatherScraps",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.LeatherScraps)
                },
                {
                    "Leech_BiteAttack",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Leech_BiteAttack)
                },
                {
                    "LinenThread",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.LinenThread)
                },
                {
                    "LoxMeat",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.LoxMeat)
                },
                {
                    "LoxPelt",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.LoxPelt)
                },
                {
                    "LoxPie",
                    new GameObjectProperties(10, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.LoxPie)
                },
                {
                    "lox_bite",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.lox_bite)
                },
                {
                    "lox_stomp",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.lox_stomp)
                },
                {
                    "MaceBronze",
                    new GameObjectProperties(1, 4, 0, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.MaceBronze)
                },
                {
                    "MaceIron",
                    new GameObjectProperties(1, 4, 0, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.MaceIron)
                },
                {
                    "MaceNeedle",
                    new GameObjectProperties(1, 4, 0, 150, 50, true,
                        ValheimCharacterEditor.Properties.Resources.MaceNeedle)
                },
                {
                    "MaceSilver",
                    new GameObjectProperties(1, 4, 0, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.MaceSilver)
                },
                {
                    "MeadBaseFrostResist",
                    new GameObjectProperties(1, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.MeadBaseFrostResist)
                },
                {
                    "MeadBaseHealthMedium",
                    new GameObjectProperties(1, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.MeadBaseHealthMedium)
                },
                {
                    "MeadBaseHealthMinor",
                    new GameObjectProperties(1, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.MeadBaseHealthMinor)
                },
                {
                    "MeadBasePoisonResist",
                    new GameObjectProperties(1, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.MeadBasePoisonResist)
                },
                {
                    "MeadBaseStaminaMedium",
                    new GameObjectProperties(1, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.MeadBaseStaminaMedium)
                },
                {
                    "MeadBaseStaminaMinor",
                    new GameObjectProperties(1, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.MeadBaseStaminaMinor)
                },
                {
                    "MeadBaseTasty",
                    new GameObjectProperties(1, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.MeadBaseTasty)
                },
                {
                    "MeadFrostResist",
                    new GameObjectProperties(10, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.MeadFrostResist)
                },
                {
                    "MeadHealthMedium",
                    new GameObjectProperties(10, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.MeadHealthMedium)
                },
                {
                    "MeadHealthMinor",
                    new GameObjectProperties(10, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.MeadHealthMinor)
                },
                {
                    "MeadPoisonResist",
                    new GameObjectProperties(10, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.MeadPoisonResist)
                },
                {
                    "MeadStaminaMedium",
                    new GameObjectProperties(10, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.MeadStaminaMedium)
                },
                {
                    "MeadStaminaMinor",
                    new GameObjectProperties(10, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.MeadStaminaMinor)
                },
                {
                    "MeadTasty",
                    new GameObjectProperties(10, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.MeadTasty)
                },
                {
                    "Mushroom",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Mushroom)
                },
                {
                    "MushroomBlue",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.MushroomBlue)
                },
                {
                    "MushroomYellow",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.MushroomYellow)
                },
                {
                    "NeckTail",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.NeckTail)
                },
                {
                    "NeckTailGrilled",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.NeckTailGrilled)
                },
                {
                    "Neck_BiteAttack",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Neck_BiteAttack)
                },
                {
                    "Needle",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Needle)
                },
                {
                    "Obsidian",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Obsidian)
                },
                {
                    "Ooze",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Ooze)
                },
                {
                    "PickaxeAntler",
                    new GameObjectProperties(1, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.PickaxeAntler)
                },
                {
                    "PickaxeBronze",
                    new GameObjectProperties(1, 4, 0, 120, 50, true,
                        ValheimCharacterEditor.Properties.Resources.PickaxeBronze)
                },
                {
                    "PickaxeIron",
                    new GameObjectProperties(1, 4, 0, 150, 50, true,
                        ValheimCharacterEditor.Properties.Resources.PickaxeIron)
                },
                {
                    "PickaxeStone",
                    new GameObjectProperties(1, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.PickaxeStone)
                },
                {
                    "PineCone",
                    new GameObjectProperties(100, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.PineCone)
                },
                {
                    "PlayerUnarmed",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.PlayerUnarmed)
                },
                {
                    "QueenBee",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.QueenBee)
                },
                {
                    "QueensJam",
                    new GameObjectProperties(10, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.QueensJam)
                },
                {
                    "Raspberry",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Raspberry)
                },
                {
                    "RawMeat",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.RawMeat)
                },
                {
                    "Resin",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Resin)
                },
                {
                    "RoundLog",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.RoundLog)
                },
                {
                    "Ruby",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Ruby)
                },
                {
                    "Sausages",
                    new GameObjectProperties(20, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.Sausages)
                },
                {
                    "SerpentMeat",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.SerpentMeat)
                },
                {
                    "SerpentMeatCooked",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.SerpentMeatCooked)
                },
                {
                    "SerpentScale",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.SerpentScale)
                },
                {
                    "SerpentStew",
                    new GameObjectProperties(10, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.SerpentStew)
                },
                {
                    "Serpent_attack",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Serpent_attack)
                },
                {
                    "Serpent_taunt",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Serpent_taunt)
                },
                {
                    "SharpeningStone",
                    new GameObjectProperties(20, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.SharpeningStone)
                },
                {
                    "ShieldBanded",
                    new GameObjectProperties(1, 3, 4, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ShieldBanded)
                },
                {
                    "ShieldBlackmetal",
                    new GameObjectProperties(1, 3, 7, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ShieldBlackmetal)
                },
                {
                    "ShieldBlackmetalTower",
                    new GameObjectProperties(1, 3, 7, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ShieldBlackmetalTower)
                },
                {
                    "ShieldBronzeBuckler",
                    new GameObjectProperties(1, 3, 0, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ShieldBronzeBuckler)
                },
                {
                    "ShieldIronSquare",
                    new GameObjectProperties(1, 3, 0, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ShieldIronSquare)
                },
                {
                    "ShieldIronTower",
                    new GameObjectProperties(1, 3, 7, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ShieldIronTower)
                },
                {
                    "ShieldKnight",
                    new GameObjectProperties(1, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ShieldKnight)
                },
                {
                    "ShieldSerpentscale",
                    new GameObjectProperties(1, 3, 0, 250, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ShieldSerpentscale)
                },
                {
                    "ShieldSilver",
                    new GameObjectProperties(1, 3, 7, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ShieldSilver)
                },
                {
                    "ShieldWood",
                    new GameObjectProperties(1, 3, 4, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ShieldWood)
                },
                {
                    "ShieldWoodTower",
                    new GameObjectProperties(1, 3, 7, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.ShieldWoodTower)
                },
                {
                    "Silver",
                    new GameObjectProperties(30, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Silver)
                },
                {
                    "SilverNecklace",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.SilverNecklace)
                },
                {
                    "SilverOre",
                    new GameObjectProperties(30, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.SilverOre)
                },
                {
                    "skeleton_bow",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.skeleton_bow)
                },
                {
                    "skeleton_mace",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.skeleton_mace)
                },
                {
                    "skeleton_sword",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.skeleton_sword)
                },
                {
                    "SledgeCheat",
                    new GameObjectProperties(1, 4, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.SledgeCheat)
                },
                {
                    "SledgeIron",
                    new GameObjectProperties(1, 4, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.SledgeIron)
                },
                {
                    "SledgeStagbreaker",
                    new GameObjectProperties(1, 4, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.SledgeStagbreaker)
                },
                {
                    "SpearBronze",
                    new GameObjectProperties(1, 4, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.SpearBronze)
                },
                {
                    "SpearChitin",
                    new GameObjectProperties(1, 1, 0, 50, 50, true,
                        ValheimCharacterEditor.Properties.Resources.SpearChitin)
                },
                {
                    "SpearElderbark",
                    new GameObjectProperties(1, 4, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.SpearElderbark)
                },
                {
                    "SpearFlint",
                    new GameObjectProperties(1, 4, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.SpearFlint)
                },
                {
                    "SpearWolfFang",
                    new GameObjectProperties(1, 4, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.SpearWolfFang)
                },
                {
                    "StaminaUpgrade_Greydwarf",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.StaminaUpgrade_Greydwarf)
                },
                {
                    "StaminaUpgrade_Troll",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.StaminaUpgrade_Troll)
                },
                {
                    "StaminaUpgrade_Wraith",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.StaminaUpgrade_Wraith)
                },
                {
                    "Stone",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Stone)
                },
                {
                    "stonegolem_attack1_spike",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.stonegolem_attack1_spike)
                },
                {
                    "stonegolem_attack2_left_groundslam",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.stonegolem_attack2_left_groundslam)
                },
                {
                    "stonegolem_attack3_spikesweep",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.stonegolem_attack3_spikesweep)
                },
                {
                    "stonegolem_attack_doublesmash",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.stonegolem_attack_doublesmash)
                },
                {
                    "stonegolem_attack_sonicboom_NOTUSED",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.stonegolem_attack_sonicboom_NOTUSED)
                },
                {
                    "StoneGolem_clubs",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.StoneGolem_clubs)
                },
                {
                    "StoneGolem_hat",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.StoneGolem_hat)
                },
                {
                    "StoneGolem_spikes",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.StoneGolem_spikes)
                },
                {
                    "SurtlingCore",
                    new GameObjectProperties(10, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.SurtlingCore)
                },
                {
                    "SwordBlackmetal",
                    new GameObjectProperties(1, 4, 0, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.SwordBlackmetal)
                },
                {
                    "SwordBronze",
                    new GameObjectProperties(1, 4, 0, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.SwordBronze)
                },
                {
                    "SwordCheat",
                    new GameObjectProperties(1, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.SwordCheat)
                },
                {
                    "SwordIron",
                    new GameObjectProperties(1, 4, 0, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.SwordIron)
                },
                {
                    "SwordIronFire",
                    new GameObjectProperties(1, 4, 0, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.SwordIronFire)
                },
                {
                    "SwordSilver",
                    new GameObjectProperties(1, 4, 0, 200, 50, true,
                        ValheimCharacterEditor.Properties.Resources.SwordSilver)
                },
                {
                    "Tankard",
                    new GameObjectProperties(1, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.Tankard)
                },
                {
                    "TankardOdin",
                    new GameObjectProperties(1, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.TankardOdin)
                },
                {
                    "tentaroot_attack",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.tentaroot_attack)
                },
                {
                    "Thistle",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Thistle)
                },
                {
                    "Tin",
                    new GameObjectProperties(30, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Tin)
                },
                {
                    "TinOre",
                    new GameObjectProperties(30, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TinOre)
                },
                {
                    "Torch",
                    new GameObjectProperties(1, 1, 0, 20, 50, true,
                        ValheimCharacterEditor.Properties.Resources.Torch)
                },
                {
                    "TrollHide",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrollHide)
                },
                {
                    "troll_groundslam",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.troll_groundslam)
                },
                {
                    "troll_log_swing_h",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.troll_log_swing_h)
                },
                {
                    "troll_log_swing_v",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.troll_log_swing_v)
                },
                {
                    "troll_punch",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.troll_punch)
                },
                {
                    "troll_throw",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.troll_throw)
                },
                {
                    "TrophyBlob",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyBlob)
                },
                {
                    "TrophyBoar",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyBoar)
                },
                {
                    "TrophyBonemass",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyBonemass)
                },
                {
                    "TrophyDeathsquito",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyDeathsquito)
                },
                {
                    "TrophyDeer",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyDeer)
                },
                {
                    "TrophyDragonQueen",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyDragonQueen)
                },
                {
                    "TrophyDraugr",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyDraugr)
                },
                {
                    "TrophyDraugrElite",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyDraugrElite)
                },
                {
                    "TrophyDraugrFem",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyDraugrFem)
                },
                {
                    "TrophyEikthyr",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyEikthyr)
                },
                {
                    "TrophyFenring",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyFenring)
                },
                {
                    "TrophyForestTroll",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyForestTroll)
                },
                {
                    "TrophyFrostTroll",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyFrostTroll)
                },
                {
                    "TrophyGoblin",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyGoblin)
                },
                {
                    "TrophyGoblinBrute",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyGoblinBrute)
                },
                {
                    "TrophyGoblinKing",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyGoblinKing)
                },
                {
                    "TrophyGoblinShaman",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyGoblinShaman)
                },
                {
                    "TrophyGreydwarf",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyGreydwarf)
                },
                {
                    "TrophyGreydwarfBrute",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyGreydwarfBrute)
                },
                {
                    "TrophyGreydwarfShaman",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyGreydwarfShaman)
                },
                {
                    "TrophyHatchling",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyHatchling)
                },
                {
                    "TrophyLeech",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyLeech)
                },
                {
                    "TrophyLox",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyLox)
                },
                {
                    "TrophyNeck",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyNeck)
                },
                {
                    "TrophySerpent",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophySerpent)
                },
                {
                    "TrophySGolem",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophySGolem)
                },
                {
                    "TrophySkeleton",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophySkeleton)
                },
                {
                    "TrophySkeletonPoison",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophySkeletonPoison)
                },
                {
                    "TrophySurtling",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophySurtling)
                },
                {
                    "TrophyTheElder",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyTheElder)
                },
                {
                    "TrophyWolf",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyWolf)
                },
                {
                    "TrophyWraith",
                    new GameObjectProperties(20, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TrophyWraith)
                },
                {
                    "Turnip",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Turnip)
                },
                {
                    "TurnipSeeds",
                    new GameObjectProperties(100, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.TurnipSeeds)
                },
                {
                    "TurnipStew",
                    new GameObjectProperties(10, 1, 0, 100, 50, true,
                        ValheimCharacterEditor.Properties.Resources.TurnipStew)
                },
                {
                    "VegvisirShard_Bonemass",
                    new GameObjectProperties(30, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.VegvisirShard_Bonemass)
                },
                {
                    "Wishbone",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Wishbone)
                },
                {
                    "WitheredBone",
                    new GameObjectProperties(30, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.WitheredBone)
                },
                {
                    "WolfFang",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.WolfFang)
                },
                {
                    "WolfPelt",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.WolfPelt)
                },
                {
                    "Wolf_Attack1",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Wolf_Attack1)
                },
                {
                    "Wolf_Attack2",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Wolf_Attack2)
                },
                {
                    "Wolf_Attack3",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Wolf_Attack3)
                },
                {
                    "Wood",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.Wood)
                },
                {
                    "wraith_melee",
                    new GameObjectProperties(1, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.wraith_melee)
                },
                {
                    "YagluthDrop",
                    new GameObjectProperties(30, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.YagluthDrop)
                },
                {
                    "YmirRemains",
                    new GameObjectProperties(50, 1, 0, 100, 50, false,
                        ValheimCharacterEditor.Properties.Resources.YmirRemains)
                }
            };

    }
}

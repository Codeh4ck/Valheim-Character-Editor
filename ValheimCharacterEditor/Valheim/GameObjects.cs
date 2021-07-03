using System.Collections.Generic;

namespace ValheimCharacterEditor.Valheim
{
    public class GameObjects
    {
        public static Dictionary<string, GameObjectProperties> ItemProperties =
            new Dictionary<string, GameObjectProperties>()
            {
                {
                    "Amber",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Amber)
                },
                {
                    "AmberPearl",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.AmberPearl)
                },
                {
                    "AncientSeed",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.AncientSeed)
                },
                {
                    "ArmorBronzeChest",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 1000,
                        durabilityPerLevel: 200, craftable: true, displayName: Properties.Resources.ArmorBronzeChest)
                },
                {
                    "ArmorBronzeLegs",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 1000,
                        durabilityPerLevel: 200, craftable: true, displayName: Properties.Resources.ArmorBronzeLegs)
                },
                {
                    "ArmorIronChest",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 1000,
                        durabilityPerLevel: 200, craftable: true, displayName: Properties.Resources.ArmorIronChest)
                },
                {
                    "ArmorIronLegs",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 1000,
                        durabilityPerLevel: 200, craftable: true, displayName: Properties.Resources.ArmorIronLegs)
                },
                {
                    "ArmorLeatherChest",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 400,
                        durabilityPerLevel: 100, craftable: true, displayName: Properties.Resources.ArmorLeatherChest)
                },
                {
                    "ArmorLeatherLegs",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 400,
                        durabilityPerLevel: 100, craftable: true, displayName: Properties.Resources.ArmorLeatherLegs)
                },
                {
                    "ArmorPaddedCuirass",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 1000,
                        durabilityPerLevel: 200, craftable: true, displayName: Properties.Resources.ArmorPaddedCuirass)
                },
                {
                    "ArmorPaddedGreaves",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 1000,
                        durabilityPerLevel: 200, craftable: true, displayName: Properties.Resources.ArmorPaddedGreaves)
                },
                {
                    "ArmorRagsChest",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 2, maxVariants: 0, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ArmorRagsChest)
                },
                {
                    "ArmorRagsLegs",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 2, maxVariants: 0, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ArmorRagsLegs)
                },
                {
                    "ArmorTrollLeatherChest",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 500,
                        durabilityPerLevel: 200, craftable: true,
                        displayName: Properties.Resources.ArmorTrollLeatherChest)
                },
                {
                    "ArmorTrollLeatherLegs",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 500,
                        durabilityPerLevel: 200, craftable: true,
                        displayName: Properties.Resources.ArmorTrollLeatherLegs)
                },
                {
                    "ArmorWolfChest",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 1000,
                        durabilityPerLevel: 200, craftable: true, displayName: Properties.Resources.ArmorWolfChest)
                },
                {
                    "ArmorWolfLegs",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 1000,
                        durabilityPerLevel: 200, craftable: true, displayName: Properties.Resources.ArmorWolfLegs)
                },
                {
                    "ArrowBronze",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ArrowBronze)
                },
                {
                    "ArrowFire",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ArrowFire)
                },
                {
                    "ArrowFlint",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ArrowFlint)
                },
                {
                    "ArrowFrost",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ArrowFrost)
                },
                {
                    "ArrowIron",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ArrowIron)
                },
                {
                    "ArrowNeedle",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ArrowNeedle)
                },
                {
                    "ArrowObsidian",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ArrowObsidian)
                },
                {
                    "ArrowPoison",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ArrowPoison)
                },
                {
                    "ArrowSilver",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ArrowSilver)
                },
                {
                    "ArrowWood",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ArrowWood)
                },
                {
                    "AtgeirBlackmetal",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 175,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.AtgeirBlackmetal)
                },
                {
                    "AtgeirBronze",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 125,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.AtgeirBronze)
                },
                {
                    "AtgeirIron",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 175,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.AtgeirIron)
                },
                {
                    "AxeBlackMetal",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 175,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.AxeBlackMetal)
                },
                {
                    "AxeBronze",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 125,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.AxeBronze)
                },
                {
                    "AxeFlint",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 30, craftable: true, displayName: Properties.Resources.AxeFlint)
                },
                {
                    "AxeIron",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 175,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.AxeIron)
                },
                {
                    "AxeStone",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 30, craftable: true, displayName: Properties.Resources.AxeStone)
                },
                {
                    "Barley",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.Barley)
                },
                {
                    "BarleyFlour",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.BarleyFlour)
                },
                {
                    "BarleyWine",
                    new GameObjectProperties(maxStackSize: 10, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.BarleyWine)
                },
                {
                    "BarleyWineBase",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.BarleyWineBase)
                },
                {
                    "Battleaxe",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.Battleaxe)
                },
                {
                    "Beard1",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Beard1)
                },
                {
                    "Beard10",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Beard10)
                },
                {
                    "Beard2",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Beard2)
                },
                {
                    "Beard3",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Beard3)
                },
                {
                    "Beard4",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Beard4)
                },
                {
                    "Beard5",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Beard5)
                },
                {
                    "Beard6",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Beard6)
                },
                {
                    "Beard7",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Beard7)
                },
                {
                    "Beard8",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Beard8)
                },
                {
                    "Beard9",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Beard9)
                },
                {
                    "BeardNone",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.BeardNone)
                },
                {
                    "BeechSeeds",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.BeechSeeds)
                },
                {
                    "BeltStrength",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.BeltStrength)
                },
                {
                    "BlackMetal",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.BlackMetal)
                },
                {
                    "BlackMetalScrap",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.BlackMetalScrap)
                },
                {
                    "blobelite_attack_aoe",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.blobelite_attack_aoe)
                },
                {
                    "blob_attack_aoe",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.blob_attack_aoe)
                },
                {
                    "Bloodbag",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Bloodbag)
                },
                {
                    "BloodPudding",
                    new GameObjectProperties(maxStackSize: 10, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.BloodPudding)
                },
                {
                    "Blueberries",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Blueberries)
                },
                {
                    "boar_base_attack",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.boar_base_attack)
                },
                {
                    "BombOoze",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.BombOoze)
                },
                {
                    "BoneFragments",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.BoneFragments)
                },
                {
                    "bonemass_attack_aoe",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.bonemass_attack_aoe)
                },
                {
                    "bonemass_attack_punch",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.bonemass_attack_punch)
                },
                {
                    "bonemass_attack_spawn",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.bonemass_attack_spawn)
                },
                {
                    "bonemass_attack_throw",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.bonemass_attack_throw)
                },
                {
                    "Bow",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 50,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.Bow)
                },
                {
                    "BowDraugrFang",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.BowDraugrFang)
                },
                {
                    "BowFineWood",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.BowFineWood)
                },
                {
                    "BowHuntsman",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.BowHuntsman)
                },
                {
                    "Bread",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.Bread)
                },
                {
                    "Bronze",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.Bronze)
                },
                {
                    "BronzeNails",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.BronzeNails)
                },
                {
                    "CapeDeerHide",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 400,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.CapeDeerHide)
                },
                {
                    "CapeLinen",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 6, maxDurability: 1500,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.CapeLinen)
                },
                {
                    "CapeLox",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 1200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.CapeLox)
                },
                {
                    "CapeOdin",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 1, maxDurability: 1500,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.CapeOdin)
                },
                {
                    "CapeTest",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.CapeTest)
                },
                {
                    "CapeTrollHide",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 500,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.CapeTrollHide)
                },
                {
                    "CapeWolf",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 1000,
                        durabilityPerLevel: 200, craftable: true, displayName: Properties.Resources.CapeWolf)
                },
                {
                    "Carrot",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Carrot)
                },
                {
                    "CarrotSeeds",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.CarrotSeeds)
                },
                {
                    "CarrotSoup",
                    new GameObjectProperties(maxStackSize: 10, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.CarrotSoup)
                },
                {
                    "Chain",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Chain)
                },
                {
                    "Chitin",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Chitin)
                },
                {
                    "Cloudberry",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Cloudberry)
                },
                {
                    "Club",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.Club)
                },
                {
                    "Coal",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Coal)
                },
                {
                    "Coins",
                    new GameObjectProperties(maxStackSize: 999, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Coins)
                },
                {
                    "CookedLoxMeat",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.CookedLoxMeat)
                },
                {
                    "CookedMeat",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.CookedMeat)
                },
                {
                    "Copper",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Copper)
                },
                {
                    "CopperOre",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.CopperOre)
                },
                {
                    "CryptKey",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.CryptKey)
                },
                {
                    "Crystal",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Crystal)
                },
                {
                    "Cultivator",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 3, maxVariants: 0, maxDurability: 200,
                        durabilityPerLevel: 200, craftable: true, displayName: Properties.Resources.Cultivator)
                },
                {
                    "Dandelion",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Dandelion)
                },
                {
                    "Deathsquito_sting",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Deathsquito_sting)
                },
                {
                    "DeerHide",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.DeerHide)
                },
                {
                    "DragonEgg",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.DragonEgg)
                },
                {
                    "DragonTear",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.DragonTear)
                },
                {
                    "dragon_bite",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.dragon_bite)
                },
                {
                    "dragon_claw_left",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.dragon_claw_left)
                },
                {
                    "dragon_claw_right",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.dragon_claw_right)
                },
                {
                    "dragon_coldbreath",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.dragon_coldbreath)
                },
                {
                    "dragon_coldbreath_OLD",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.dragon_coldbreath_OLD)
                },
                {
                    "dragon_spit_shotgun",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.dragon_spit_shotgun)
                },
                {
                    "dragon_taunt",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.dragon_taunt)
                },
                {
                    "draugr_arrow",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.draugr_arrow)
                },
                {
                    "draugr_axe",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.draugr_axe)
                },
                {
                    "draugr_bow",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.draugr_bow)
                },
                {
                    "draugr_sword",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.draugr_sword)
                },
                {
                    "Eikthyr_antler",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Eikthyr_antler)
                },
                {
                    "Eikthyr_charge",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Eikthyr_charge)
                },
                {
                    "Eikthyr_flegs_OLD",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Eikthyr_flegs_OLD)
                },
                {
                    "Eikthyr_stomp",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Eikthyr_stomp)
                },
                {
                    "ElderBark",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.ElderBark)
                },
                {
                    "Entrails",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Entrails)
                },
                {
                    "Feathers",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Feathers)
                },
                {
                    "Fenring_attack_claw",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Fenring_attack_claw)
                },
                {
                    "Fenring_attack_jump",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Fenring_attack_jump)
                },
                {
                    "Fenring_taunt",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Fenring_taunt)
                },
                {
                    "FineWood",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.FineWood)
                },
                {
                    "FirCone",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.FirCone)
                },
                {
                    "FishCooked",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.FishCooked)
                },
                {
                    "FishingBait",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.FishingBait)
                },
                {
                    "FishingRod",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.FishingRod)
                },
                {
                    "FishRaw",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.FishRaw)
                },
                {
                    "FishWraps",
                    new GameObjectProperties(maxStackSize: 10, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.FishWraps)
                },
                {
                    "Flametal",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Flametal)
                },
                {
                    "FlametalOre",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.FlametalOre)
                },
                {
                    "Flax",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Flax)
                },
                {
                    "Flint",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Flint)
                },
                {
                    "FreezeGland",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.FreezeGland)
                },
                {
                    "gd_king_punch",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.gd_king_punch)
                },
                {
                    "gd_king_rootspawn",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.gd_king_rootspawn)
                },
                {
                    "gd_king_scream",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.gd_king_scream)
                },
                {
                    "gd_king_shoot",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.gd_king_shoot)
                },
                {
                    "gd_king_stomp",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.gd_king_stomp)
                },
                {
                    "Ghost_attack",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Ghost_attack)
                },
                {
                    "GoblinArmband",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.GoblinArmband)
                },
                {
                    "GoblinBrute_ArmGuard",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.GoblinBrute_ArmGuard)
                },
                {
                    "GoblinBrute_Attack",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 7, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.GoblinBrute_Attack)
                },
                {
                    "GoblinBrute_Backbones",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.GoblinBrute_Backbones)
                },
                {
                    "GoblinBrute_ExecutionerCap",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.GoblinBrute_ExecutionerCap)
                },
                {
                    "GoblinBrute_HipCloth",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.GoblinBrute_HipCloth)
                },
                {
                    "GoblinBrute_LegBones",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.GoblinBrute_LegBones)
                },
                {
                    "GoblinBrute_RageAttack",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 7, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.GoblinBrute_RageAttack)
                },
                {
                    "GoblinBrute_ShoulderGuard",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.GoblinBrute_ShoulderGuard)
                },
                {
                    "GoblinBrute_Taunt",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 7, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.GoblinBrute_Taunt)
                },
                {
                    "GoblinClub",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.GoblinClub)
                },
                {
                    "GoblinHelmet",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.GoblinHelmet)
                },
                {
                    "GoblinKing_Beam",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.GoblinKing_Beam)
                },
                {
                    "GoblinKing_Meteors",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.GoblinKing_Meteors)
                },
                {
                    "GoblinKing_Nova",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.GoblinKing_Nova)
                },
                {
                    "GoblinKing_Taunt",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.GoblinKing_Taunt)
                },
                {
                    "GoblinLegband",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.GoblinLegband)
                },
                {
                    "GoblinLoin",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.GoblinLoin)
                },
                {
                    "GoblinShaman_attack_fireball",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.GoblinShaman_attack_fireball)
                },
                {
                    "GoblinShaman_attack_poke",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.GoblinShaman_attack_poke)
                },
                {
                    "GoblinShaman_attack_protect",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.GoblinShaman_attack_protect)
                },
                {
                    "GoblinShaman_Headdress_antlers",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.GoblinShaman_Headdress_antlers)
                },
                {
                    "GoblinShaman_Headdress_feathers",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.GoblinShaman_Headdress_feathers)
                },
                {
                    "GoblinShaman_Staff_Bones",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.GoblinShaman_Staff_Bones)
                },
                {
                    "GoblinShaman_Staff_Feathers",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.GoblinShaman_Staff_Feathers)
                },
                {
                    "GoblinShoulders",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.GoblinShoulders)
                },
                {
                    "GoblinSpear",
                    new GameObjectProperties(maxStackSize: 10, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.GoblinSpear)
                },
                {
                    "GoblinSword",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 7, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.GoblinSword)
                },
                {
                    "GoblinTorch",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.GoblinTorch)
                },
                {
                    "GoblinTotem",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.GoblinTotem)
                },
                {
                    "GreydwarfEye",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.GreydwarfEye)
                },
                {
                    "Greydwarf_attack",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Greydwarf_attack)
                },
                {
                    "Greydwarf_elite_attack",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.Greydwarf_elite_attack)
                },
                {
                    "Greydwarf_shaman_attack",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.Greydwarf_shaman_attack)
                },
                {
                    "Greydwarf_shaman_heal",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.Greydwarf_shaman_heal)
                },
                {
                    "Greydwarf_throw",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Greydwarf_throw)
                },
                {
                    "Greyling_attack",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Greyling_attack)
                },
                {
                    "Guck",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Guck)
                },
                {
                    "Hair1",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Hair1)
                },
                {
                    "Hair10",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Hair10)
                },
                {
                    "Hair11",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Hair11)
                },
                {
                    "Hair12",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Hair12)
                },
                {
                    "Hair13",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Hair13)
                },
                {
                    "Hair14",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Hair14)
                },
                {
                    "Hair2",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Hair2)
                },
                {
                    "Hair3",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Hair3)
                },
                {
                    "Hair4",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Hair4)
                },
                {
                    "Hair5",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Hair5)
                },
                {
                    "Hair6",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Hair6)
                },
                {
                    "Hair7",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Hair7)
                },
                {
                    "Hair8",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Hair8)
                },
                {
                    "Hair9",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Hair9)
                },
                {
                    "HairNone",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.HairNone)
                },
                {
                    "Hammer",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 3, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 100, craftable: true, displayName: Properties.Resources.Hammer)
                },
                {
                    "HardAntler",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.HardAntler)
                },
                {
                    "hatchling_spit_cold",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.hatchling_spit_cold)
                },
                {
                    "HealthUpgrade_Bonemass",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.HealthUpgrade_Bonemass)
                },
                {
                    "HealthUpgrade_GDKing",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.HealthUpgrade_GDKing)
                },
                {
                    "HelmetBronze",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 1000,
                        durabilityPerLevel: 200, craftable: true, displayName: Properties.Resources.HelmetBronze)
                },
                {
                    "HelmetDrake",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 1000,
                        durabilityPerLevel: 200, craftable: true, displayName: Properties.Resources.HelmetDrake)
                },
                {
                    "HelmetDverger",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 1000,
                        durabilityPerLevel: 100, craftable: true, displayName: Properties.Resources.HelmetDverger)
                },
                {
                    "HelmetIron",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 1000,
                        durabilityPerLevel: 200, craftable: true, displayName: Properties.Resources.HelmetIron)
                },
                {
                    "HelmetLeather",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 400,
                        durabilityPerLevel: 100, craftable: true, displayName: Properties.Resources.HelmetLeather)
                },
                {
                    "HelmetOdin",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 300,
                        durabilityPerLevel: 100, craftable: true, displayName: Properties.Resources.HelmetOdin)
                },
                {
                    "HelmetPadded",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 1000,
                        durabilityPerLevel: 200, craftable: true, displayName: Properties.Resources.HelmetPadded)
                },
                {
                    "HelmetTrollLeather",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 500,
                        durabilityPerLevel: 200, craftable: true, displayName: Properties.Resources.HelmetTrollLeather)
                },
                {
                    "HelmetYule",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 1000,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.HelmetYule)
                },
                {
                    "Hoe",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 3, maxVariants: 0, maxDurability: 200,
                        durabilityPerLevel: 200, craftable: true, displayName: Properties.Resources.Hoe)
                },
                {
                    "Honey",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Honey)
                },
                {
                    "imp_fireball_attack",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.imp_fireball_attack)
                },
                {
                    "Iron",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Iron)
                },
                {
                    "IronNails",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.IronNails)
                },
                {
                    "IronOre",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.IronOre)
                },
                {
                    "IronScrap",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.IronScrap)
                },
                {
                    "KnifeBlackMetal",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.KnifeBlackMetal)
                },
                {
                    "KnifeChitin",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.KnifeChitin)
                },
                {
                    "KnifeCopper",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.KnifeCopper)
                },
                {
                    "KnifeFlint",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.KnifeFlint)
                },
                {
                    "LeatherScraps",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.LeatherScraps)
                },
                {
                    "Leech_BiteAttack",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Leech_BiteAttack)
                },
                {
                    "LinenThread",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.LinenThread)
                },
                {
                    "LoxMeat",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.LoxMeat)
                },
                {
                    "LoxPelt",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.LoxPelt)
                },
                {
                    "LoxPie",
                    new GameObjectProperties(maxStackSize: 10, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.LoxPie)
                },
                {
                    "lox_bite",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.lox_bite)
                },
                {
                    "lox_stomp",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.lox_stomp)
                },
                {
                    "MaceBronze",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.MaceBronze)
                },
                {
                    "MaceIron",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.MaceIron)
                },
                {
                    "MaceNeedle",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 150,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.MaceNeedle)
                },
                {
                    "MaceSilver",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.MaceSilver)
                },
                {
                    "MeadBaseFrostResist",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.MeadBaseFrostResist)
                },
                {
                    "MeadBaseHealthMedium",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.MeadBaseHealthMedium)
                },
                {
                    "MeadBaseHealthMinor",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.MeadBaseHealthMinor)
                },
                {
                    "MeadBasePoisonResist",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.MeadBasePoisonResist)
                },
                {
                    "MeadBaseStaminaMedium",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true,
                        displayName: Properties.Resources.MeadBaseStaminaMedium)
                },
                {
                    "MeadBaseStaminaMinor",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.MeadBaseStaminaMinor)
                },
                {
                    "MeadBaseTasty",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.MeadBaseTasty)
                },
                {
                    "MeadFrostResist",
                    new GameObjectProperties(maxStackSize: 10, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.MeadFrostResist)
                },
                {
                    "MeadHealthMedium",
                    new GameObjectProperties(maxStackSize: 10, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.MeadHealthMedium)
                },
                {
                    "MeadHealthMinor",
                    new GameObjectProperties(maxStackSize: 10, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.MeadHealthMinor)
                },
                {
                    "MeadPoisonResist",
                    new GameObjectProperties(maxStackSize: 10, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.MeadPoisonResist)
                },
                {
                    "MeadStaminaMedium",
                    new GameObjectProperties(maxStackSize: 10, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.MeadStaminaMedium)
                },
                {
                    "MeadStaminaMinor",
                    new GameObjectProperties(maxStackSize: 10, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.MeadStaminaMinor)
                },
                {
                    "MeadTasty",
                    new GameObjectProperties(maxStackSize: 10, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.MeadTasty)
                },
                {
                    "Mushroom",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Mushroom)
                },
                {
                    "MushroomBlue",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.MushroomBlue)
                },
                {
                    "MushroomYellow",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.MushroomYellow)
                },
                {
                    "NeckTail",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.NeckTail)
                },
                {
                    "NeckTailGrilled",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.NeckTailGrilled)
                },
                {
                    "Neck_BiteAttack",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Neck_BiteAttack)
                },
                {
                    "Needle",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Needle)
                },
                {
                    "Obsidian",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Obsidian)
                },
                {
                    "Ooze",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Ooze)
                },
                {
                    "PickaxeAntler",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.PickaxeAntler)
                },
                {
                    "PickaxeBronze",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 120,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.PickaxeBronze)
                },
                {
                    "PickaxeIron",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 150,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.PickaxeIron)
                },
                {
                    "PickaxeStone",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.PickaxeStone)
                },
                {
                    "PineCone",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.PineCone)
                },
                {
                    "PlayerUnarmed",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.PlayerUnarmed)
                },
                {
                    "QueenBee",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.QueenBee)
                },
                {
                    "QueensJam",
                    new GameObjectProperties(maxStackSize: 10, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.QueensJam)
                },
                {
                    "Raspberry",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Raspberry)
                },
                {
                    "RawMeat",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.RawMeat)
                },
                {
                    "Resin",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Resin)
                },
                {
                    "RoundLog",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.RoundLog)
                },
                {
                    "Ruby",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Ruby)
                },
                {
                    "Sausages",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.Sausages)
                },
                {
                    "SerpentMeat",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.SerpentMeat)
                },
                {
                    "SerpentMeatCooked",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.SerpentMeatCooked)
                },
                {
                    "SerpentScale",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.SerpentScale)
                },
                {
                    "SerpentStew",
                    new GameObjectProperties(maxStackSize: 10, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.SerpentStew)
                },
                {
                    "Serpent_attack",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Serpent_attack)
                },
                {
                    "Serpent_taunt",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Serpent_taunt)
                },
                {
                    "SharpeningStone",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.SharpeningStone)
                },
                {
                    "ShieldBanded",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 3, maxVariants: 4, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ShieldBanded)
                },
                {
                    "ShieldBlackmetal",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 3, maxVariants: 7, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ShieldBlackmetal)
                },
                {
                    "ShieldBlackmetalTower",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 3, maxVariants: 7, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true,
                        displayName: Properties.Resources.ShieldBlackmetalTower)
                },
                {
                    "ShieldBronzeBuckler",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 3, maxVariants: 0, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ShieldBronzeBuckler)
                },
                {
                    "ShieldIronSquare",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 3, maxVariants: 0, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ShieldIronSquare)
                },
                {
                    "ShieldIronTower",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 3, maxVariants: 7, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ShieldIronTower)
                },
                {
                    "ShieldKnight",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ShieldKnight)
                },
                {
                    "ShieldSerpentscale",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 3, maxVariants: 0, maxDurability: 250,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ShieldSerpentscale)
                },
                {
                    "ShieldSilver",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 3, maxVariants: 7, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ShieldSilver)
                },
                {
                    "ShieldWood",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 3, maxVariants: 4, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ShieldWood)
                },
                {
                    "ShieldWoodTower",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 3, maxVariants: 7, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.ShieldWoodTower)
                },
                {
                    "Silver",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Silver)
                },
                {
                    "SilverNecklace",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.SilverNecklace)
                },
                {
                    "SilverOre",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.SilverOre)
                },
                {
                    "skeleton_bow",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.skeleton_bow)
                },
                {
                    "skeleton_mace",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.skeleton_mace)
                },
                {
                    "skeleton_sword",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.skeleton_sword)
                },
                {
                    "SledgeCheat",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.SledgeCheat)
                },
                {
                    "SledgeIron",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.SledgeIron)
                },
                {
                    "SledgeStagbreaker",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.SledgeStagbreaker)
                },
                {
                    "SpearBronze",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.SpearBronze)
                },
                {
                    "SpearChitin",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 50,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.SpearChitin)
                },
                {
                    "SpearElderbark",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.SpearElderbark)
                },
                {
                    "SpearFlint",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.SpearFlint)
                },
                {
                    "SpearWolfFang",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.SpearWolfFang)
                },
                {
                    "StaminaUpgrade_Greydwarf",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.StaminaUpgrade_Greydwarf)
                },
                {
                    "StaminaUpgrade_Troll",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.StaminaUpgrade_Troll)
                },
                {
                    "StaminaUpgrade_Wraith",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.StaminaUpgrade_Wraith)
                },
                {
                    "Stone",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Stone)
                },
                {
                    "stonegolem_attack1_spike",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.stonegolem_attack1_spike)
                },
                {
                    "stonegolem_attack2_left_groundslam",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.stonegolem_attack2_left_groundslam)
                },
                {
                    "stonegolem_attack3_spikesweep",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.stonegolem_attack3_spikesweep)
                },
                {
                    "stonegolem_attack_doublesmash",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.stonegolem_attack_doublesmash)
                },
                {
                    "stonegolem_attack_sonicboom_NOTUSED",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.stonegolem_attack_sonicboom_NOTUSED)
                },
                {
                    "StoneGolem_clubs",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.StoneGolem_clubs)
                },
                {
                    "StoneGolem_hat",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.StoneGolem_hat)
                },
                {
                    "StoneGolem_spikes",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.StoneGolem_spikes)
                },
                {
                    "SurtlingCore",
                    new GameObjectProperties(maxStackSize: 10, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.SurtlingCore)
                },
                {
                    "SwordBlackmetal",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.SwordBlackmetal)
                },
                {
                    "SwordBronze",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.SwordBronze)
                },
                {
                    "SwordCheat",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.SwordCheat)
                },
                {
                    "SwordIron",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.SwordIron)
                },
                {
                    "SwordIronFire",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.SwordIronFire)
                },
                {
                    "SwordSilver",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 4, maxVariants: 0, maxDurability: 200,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.SwordSilver)
                },
                {
                    "Tankard",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.Tankard)
                },
                {
                    "TankardOdin",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.TankardOdin)
                },
                {
                    "tentaroot_attack",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.tentaroot_attack)
                },
                {
                    "Thistle",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Thistle)
                },
                {
                    "Tin",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Tin)
                },
                {
                    "TinOre",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TinOre)
                },
                {
                    "Torch",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 20,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.Torch)
                },
                {
                    "TrollHide",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrollHide)
                },
                {
                    "troll_groundslam",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.troll_groundslam)
                },
                {
                    "troll_log_swing_h",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.troll_log_swing_h)
                },
                {
                    "troll_log_swing_v",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.troll_log_swing_v)
                },
                {
                    "troll_punch",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.troll_punch)
                },
                {
                    "troll_throw",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.troll_throw)
                },
                {
                    "TrophyBlob",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyBlob)
                },
                {
                    "TrophyBoar",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyBoar)
                },
                {
                    "TrophyBonemass",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyBonemass)
                },
                {
                    "TrophyDeathsquito",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyDeathsquito)
                },
                {
                    "TrophyDeer",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyDeer)
                },
                {
                    "TrophyDragonQueen",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyDragonQueen)
                },
                {
                    "TrophyDraugr",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyDraugr)
                },
                {
                    "TrophyDraugrElite",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyDraugrElite)
                },
                {
                    "TrophyDraugrFem",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyDraugrFem)
                },
                {
                    "TrophyEikthyr",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyEikthyr)
                },
                {
                    "TrophyFenring",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyFenring)
                },
                {
                    "TrophyForestTroll",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyForestTroll)
                },
                {
                    "TrophyFrostTroll",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyFrostTroll)
                },
                {
                    "TrophyGoblin",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyGoblin)
                },
                {
                    "TrophyGoblinBrute",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyGoblinBrute)
                },
                {
                    "TrophyGoblinKing",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyGoblinKing)
                },
                {
                    "TrophyGoblinShaman",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyGoblinShaman)
                },
                {
                    "TrophyGreydwarf",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyGreydwarf)
                },
                {
                    "TrophyGreydwarfBrute",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.TrophyGreydwarfBrute)
                },
                {
                    "TrophyGreydwarfShaman",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.TrophyGreydwarfShaman)
                },
                {
                    "TrophyHatchling",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyHatchling)
                },
                {
                    "TrophyLeech",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyLeech)
                },
                {
                    "TrophyLox",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyLox)
                },
                {
                    "TrophyNeck",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyNeck)
                },
                {
                    "TrophySerpent",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophySerpent)
                },
                {
                    "TrophySGolem",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophySGolem)
                },
                {
                    "TrophySkeleton",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophySkeleton)
                },
                {
                    "TrophySkeletonPoison",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.TrophySkeletonPoison)
                },
                {
                    "TrophySurtling",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophySurtling)
                },
                {
                    "TrophyTheElder",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyTheElder)
                },
                {
                    "TrophyWolf",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyWolf)
                },
                {
                    "TrophyWraith",
                    new GameObjectProperties(maxStackSize: 20, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TrophyWraith)
                },
                {
                    "Turnip",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Turnip)
                },
                {
                    "TurnipSeeds",
                    new GameObjectProperties(maxStackSize: 100, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.TurnipSeeds)
                },
                {
                    "TurnipStew",
                    new GameObjectProperties(maxStackSize: 10, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: true, displayName: Properties.Resources.TurnipStew)
                },
                {
                    "VegvisirShard_Bonemass",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false,
                        displayName: Properties.Resources.VegvisirShard_Bonemass)
                },
                {
                    "Wishbone",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Wishbone)
                },
                {
                    "WitheredBone",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.WitheredBone)
                },
                {
                    "WolfFang",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.WolfFang)
                },
                {
                    "WolfPelt",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.WolfPelt)
                },
                {
                    "Wolf_Attack1",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Wolf_Attack1)
                },
                {
                    "Wolf_Attack2",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Wolf_Attack2)
                },
                {
                    "Wolf_Attack3",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Wolf_Attack3)
                },
                {
                    "Wood",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.Wood)
                },
                {
                    "wraith_melee",
                    new GameObjectProperties(maxStackSize: 1, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.wraith_melee)
                },
                {
                    "YagluthDrop",
                    new GameObjectProperties(maxStackSize: 30, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.YagluthDrop)
                },
                {
                    "YmirRemains",
                    new GameObjectProperties(maxStackSize: 50, maxQuality: 1, maxVariants: 0, maxDurability: 100,
                        durabilityPerLevel: 50, craftable: false, displayName: Properties.Resources.YmirRemains)
                }
            };
    }
}

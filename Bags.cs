using System;
using System.Collections.Generic;
using CalamityFlamethrowers.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace CalamityFlamethrowers
{
    public class Bags : GlobalItem
    {
        public override bool InstancePerEntity => true;

        public override void ModifyItemLoot(Item arg, ItemLoot itemLoot)
        {
            Mod calamityMod = ModLoader.GetMod("CalamityMod");
            if (calamityMod != null)
            {
                if (arg.type == calamityMod.Find<ModItem>("DesertScourgeBag").Type)
                {
                    itemLoot.Add(new CommonDrop(ModContent.ItemType<DesertScorcher>(), 3));
                }
                if (arg.type == calamityMod.Find<ModItem>("CrabulonBag").Type)
                {
                    itemLoot.Add(new CommonDrop(ModContent.ItemType<ToadstoolTorcher>(), 3));
                }
                if (arg.type == calamityMod.Find<ModItem>("PerforatorBag").Type)
                {
                    itemLoot.Add(new CommonDrop(ModContent.ItemType<Ichorthrower>(), 3));
                }
                if (arg.type == calamityMod.Find<ModItem>("AquaticScourgeBag").Type)
                {
                    itemLoot.Add(new CommonDrop(ModContent.ItemType<OceanScalder>(), 3));
                }
                if (arg.type == calamityMod.Find<ModItem>("BrimstoneWaifuBag").Type)
                {
                    itemLoot.Add(new CommonDrop(ModContent.ItemType<TheTorch>(), 3));
                }
                if (arg.type == calamityMod.Find<ModItem>("CryogenBag").Type)
                {
                    itemLoot.Add(new CommonDrop(ModContent.ItemType<BreathofGlacies>(), 3));
                }
                if (arg.type == calamityMod.Find<ModItem>("LeviathanBag").Type)
                {
                    itemLoot.Add(new CommonDrop(ModContent.ItemType<TubaBreathBlaster>(), 3));
                }
                if (arg.type == calamityMod.Find<ModItem>("AstrumAureusBag").Type)
                {
                    itemLoot.Add(new CommonDrop(ModContent.ItemType<AuroraFlare>(), 3));
                }
                if (arg.type == calamityMod.Find<ModItem>("RavagerBag").Type)
                {
                    itemLoot.Add(new CommonDrop(ModContent.ItemType<RookofVengeance>(), 3));
                }
                if (arg.type == calamityMod.Find<ModItem>("AstrumDeusBag").Type)
                {
                    itemLoot.Add(new CommonDrop(ModContent.ItemType<ConstellationDamnation>(), 3));
                }
                if (arg.type == calamityMod.Find<ModItem>("DragonfollyBag").Type)
                {
                    itemLoot.Add(new CommonDrop(ModContent.ItemType<EffulgentZapper>(), 3));
                }
                if (arg.type == calamityMod.Find<ModItem>("PolterghastBag").Type)
                {
                    itemLoot.Add(new CommonDrop(ModContent.ItemType<RemnantofFate>(), 3));
                }
                if (arg.type == calamityMod.Find<ModItem>("OldDukeBag").Type)
                {
                    itemLoot.Add(new CommonDrop(ModContent.ItemType<CambrianCrisper>(), 3));
                }
                if (arg.type == calamityMod.Find<ModItem>("SignusBag").Type)
                {
                    itemLoot.Add(new CommonDrop(ModContent.ItemType<CosmicFirestorm>(), 9));
                }
                if (arg.type == calamityMod.Find<ModItem>("CeaselessVoidBag").Type)
                {
                    itemLoot.Add(new CommonDrop(ModContent.ItemType<CosmicFirestorm>(), 9));
                }
                if (arg.type == calamityMod.Find<ModItem>("StormWeaverBag").Type)
                {
                    itemLoot.Add(new CommonDrop(ModContent.ItemType<CosmicFirestorm>(), 9));
                }
                if (arg.type == calamityMod.Find<ModItem>("SupremeCalamitasCoffer").Type)
                {
                    itemLoot.Add(new CommonDrop(ModContent.ItemType<Repentance>(), 3));
                }
                if (arg.type == calamityMod.Find<ModItem>("DraedonBag").Type)
                {
                    itemLoot.Add(new CommonDrop(ModContent.ItemType<Plasmalegion>(), 3));
                }
            }
        }
    }
}



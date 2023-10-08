using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityFlamethrowers;
using CalamityFlamethrowers.Items;

namespace CalamityFlamethrowers
{
	public class CalamityNpcDrops : GlobalNPC
	{
		public override void OnKill(NPC npc)
		{
			//I don't care enough to do loot code here
			Mod mod = ModLoader.GetMod("CalamityMod");
			if (mod == null)
			{
				return;
			}
			if (!Main.expertMode)
			{
				if (npc.type == mod.Find<ModNPC>("DesertScourgeHead").Type)
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<DesertScorcher>());
					}
				}
				if (npc.type == mod.Find<ModNPC>("Crabulon").Type)
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<ToadstoolTorcher>());
					}
				}
				if (npc.type == mod.Find<ModNPC>("PerforatorHive").Type)
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<Ichorthrower>());
					}
				}
				if (npc.type == mod.Find<ModNPC>("Cryogen").Type)
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<BreathofGlacies>());
					}
				}
				if (npc.type == mod.Find<ModNPC>("AquaticScourgeHead").Type)
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<OceanScalder>());
					}
				}
				if (npc.type == mod.Find<ModNPC>("BrimstoneElemental").Type)
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<TheTorch>());
					}
				}
				if (npc.type == mod.Find<ModNPC>("AstrumAureus").Type)
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<AuroraFlare>());
					}
				}
				if (npc.type == mod.Find<ModNPC>("Leviathan").Type && !NPC.AnyNPCs(mod.Find<ModNPC>("Anahita").Type))
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<TubaBreathBlaster>());
					}
				}
				if (npc.type == mod.Find<ModNPC>("Anahita").Type && !NPC.AnyNPCs(mod.Find<ModNPC>("Leviathan").Type))
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<TubaBreathBlaster>());
					}
				}
				if (npc.type == mod.Find<ModNPC>("RavagerBody").Type)
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<RookofVengeance>());
					}
				}
				if (npc.type == mod.Find<ModNPC>("AstrumDeusHead").Type && NPC.CountNPCS(mod.Find<ModNPC>("AstrumDeusHead").Type) == 1)
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<ConstellationDamnation>());
					}
				}
				if (npc.type == mod.Find<ModNPC>("ProfanedGuardianCommander").Type)
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<SerpentsBreath>());
					}
				}
				if (npc.type == mod.Find<ModNPC>("Bumblefuck").Type)
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<EffulgentZapper>());
					}
				}
				if (npc.type == mod.Find<ModNPC>("Polterghast").Type)
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<RemnantofFate>());
					}
				}
				if (npc.type == mod.Find<ModNPC>("Signus").Type)
				{
					if (Utils.NextFloat(Main.rand) < 0.08f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<CosmicFirestorm>());
					}
				}
				if (npc.type == mod.Find<ModNPC>("CeaselessVoid").Type)
				{
					if (Utils.NextFloat(Main.rand) < 0.08f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<CosmicFirestorm>());
					}
				}
				if (npc.type == mod.Find<ModNPC>("StormWeaverHead").Type)
				{
					if (Utils.NextFloat(Main.rand) < 0.08f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<CosmicFirestorm>());
					}
				}
				if (npc.type == mod.Find<ModNPC>("OldDuke").Type)
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<CambrianCrisper>());
					}
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").Find<ModNPC>("SupremeCalamitas").Type)
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<Repentance>());
					}
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").Find<ModNPC>("Apollo").Type && !NPC.AnyNPCs(ModLoader.GetMod("CalamityMod").Find<ModNPC>("AresBody").Type) && !NPC.AnyNPCs(ModLoader.GetMod("CalamityMod").Find<ModNPC>("ThanatosHead").Type))
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<Plasmalegion>());
					}
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").Find<ModNPC>("AresBody").Type && !NPC.AnyNPCs(ModLoader.GetMod("CalamityMod").Find<ModNPC>("Apollo").Type) && !NPC.AnyNPCs(ModLoader.GetMod("CalamityMod").Find<ModNPC>("ThanatosHead").Type))
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<Plasmalegion>());
					}
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").Find<ModNPC>("ThanatosHead").Type && !NPC.AnyNPCs(ModLoader.GetMod("CalamityMod").Find<ModNPC>("AresBody").Type) && !NPC.AnyNPCs(ModLoader.GetMod("CalamityMod").Find<ModNPC>("Apollo").Type))
				{
					if (Utils.NextFloat(Main.rand) < 0.25f)
					{
						Item.NewItem(npc.GetSource_Loot(),npc.getRect(), ModContent.ItemType<Plasmalegion>());
					}
				}
			}
		}
	}
}
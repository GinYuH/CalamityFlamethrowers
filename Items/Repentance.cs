using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Items
{
	public class Repentance : ModItem
	{
		public override void SetStaticDefaults() {
			// DisplayName.SetDefault("Repentance");
			// Tooltip.SetDefault("60% chance to not consume gel\nBlasts enemies with dark flames that summon more flames from beneath\nImpurity and evil desires fill this weapon with hatred...");
		}

		public override void SetDefaults()
	    {
			Item.damage = 666;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 54;
			Item.height = 14;
			Item.useTime = 21;
			Item.useAnimation = 21;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true; //so the item's animation doesn't do damage
			Item.knockBack = 6.5f;
			Item.UseSound = SoundID.Item34;
			Item.shoot = Mod.Find<ModProjectile>("DarkFire").Type;
			Item.value = 5000;
			Item.rare = 11;
			Item.autoReuse = true;
			Item.shootSpeed = 10.5f;
			Item.useAmmo = 23;
		}
		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			//rarity 12 (Turquoise) = new Color(0, 255, 200)
			//rarity 13 (Pure Green) = new Color(0, 255, 0)
			//rarity 14 (Dark Blue) = new Color(43, 96, 222)
			//rarity 15 (Violet) = new Color(108, 45, 199)
			//rarity 16 (Hot Pink/Developer) = new Color(255, 0, 255)
			//rarity rainbow (no expert tag on item) = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB)
			//rarity rare variant = new Color(255, 140, 0)
			//rarity dedicated(patron items) = new Color(139, 0, 0)
			//look at https://calamitymod.gamepedia.com/Rarity to know where to use the colors
			foreach (TooltipLine tooltipLine in tooltips)
			{
				if (tooltipLine.Mod == "Terraria" && tooltipLine.Name == "ItemName")
				{
					tooltipLine.OverrideColor = new Color(108, 45, 199); //change the color accordingly to above
				}
			}
		}

		public override bool Shoot(Player player, Terraria.DataStructures.EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{			
			Vector2 muzzleOffset = Vector2.Normalize(velocity) * 30f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
		}

		public override bool CanConsumeAmmo(Item ammo, Player player)
	    {
	    	if (Main.rand.Next(0, 100) <= 60)
	    		return false;
	    	return true;
	    }
	}
}
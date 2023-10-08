using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using System.Collections.Generic;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Items
{
	public class CambrianCrisper : ModItem
	{
		public override void SetStaticDefaults() {
			// DisplayName.SetDefault("Cambrian Crisper");
			// Tooltip.SetDefault("95% chance to not consume gel\nFires 20 streams of short ranged acidic flames\nOld !!!");
		}

		public override void SetDefaults()
	    {
			Item.damage = 700;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 54;
			Item.height = 14;
			Item.useTime = 8;
			Item.useAnimation = 8;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true; //so the item's animation doesn't do damage
			Item.knockBack = 1.5f;
			Item.UseSound = SoundID.Item34;
			Item.shoot = Mod.Find<ModProjectile>("ToxicFlame").Type;
            Item.rare = 11;
			Item.value = 5000;
			Item.autoReuse = true;
			Item.shootSpeed = 27.0f;
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
					tooltipLine.OverrideColor = new Color(0, 255, 0); //change the color accordingly to above
				}
			}
		}

		public override bool CanConsumeAmmo(Item ammo, Player player)
	    {
	    	if (Main.rand.Next(0, 100) <= 55)
	    		return false;
	    	return true;
	    }

		public override bool Shoot(Player player, Terraria.DataStructures.EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
           float numberProjectiles = 20;
			float rotation = MathHelper.ToRadians(30);
			position += Vector2.Normalize(velocity) * 30f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = velocity.RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
			}
			return false;
            
        
		}
	}
}
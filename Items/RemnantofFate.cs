using Microsoft.Xna.Framework;
using Terraria;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Items
{
	public class RemnantofFate : ModItem
	{
		public override void SetStaticDefaults() {
			// DisplayName.SetDefault("Remnant of Fate");
			// Tooltip.SetDefault("66% chance to not consume gel\nCycles through Phantoplasm and Ectoplasm streams\nPhantoplasm flames inflict several debuffs\nFlames reach farther in the opposite direction\nsomething new something blue");
		}

		public override void SetDefaults()
	    {
			Item.damage = 200;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 54;
			Item.height = 14;
			Item.useTime = 5;
			Item.useAnimation = 5;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true; //so the item's animation doesn't do damage
			Item.knockBack = 3.5f;
			Item.UseSound = SoundID.Item34;
			Item.shoot = Mod.Find<ModProjectile>("GhostFlame").Type;
            Item.rare = 11;
			Item.value = 5000;
			Item.autoReuse = true;
			Item.shootSpeed = 40.0f;
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
	    	if (Main.rand.Next(0, 100) <= 66)
	    		return false;
	    	return true;
	    }

		public override bool Shoot(Player player, Terraria.DataStructures.EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
             type = Main.rand.Next(new int[] { type, Mod.Find<ModProjectile>("GhostFlame").Type, Mod.Find<ModProjectile>("PhantomFlame").Type});
           float numberProjectiles = 2;
			float rotation = MathHelper.ToRadians(180);
			position += Vector2.Normalize(velocity) * 180f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = velocity.RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
			}
			return false;
            
        
		}

	public override Vector2? HoldoutOffset()
		{
			return new Vector2(-40, 0);
		}


	}

}
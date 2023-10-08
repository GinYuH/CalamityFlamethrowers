using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Items
{
	public class DesertScorcher : ModItem
	{
		public override void SetStaticDefaults() {
			// DisplayName.SetDefault("Desert Scorcher");
			// Tooltip.SetDefault("15% chance to not consume gel\nShoots a short ranged blast of flames that burn like the desert");
		}

		public override void SetDefaults()
	    {
			Item.damage = 13;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 54;
			Item.height = 14;
			Item.useTime = 6;
			Item.useAnimation = 18;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true; //so the item's animation doesn't do damage
			Item.knockBack = 1.5f;
			Item.UseSound = SoundID.Item34;
			Item.shoot = Mod.Find<ModProjectile>("DesertFlame").Type;
			Item.value = 5000;
			Item.rare = 2;
			Item.autoReuse = true;
			Item.shootSpeed = 5.5f;
			Item.useAmmo = 23;
		}

		public override bool CanConsumeAmmo(Item ammo, Player player)
	    {
	    	if (Main.rand.Next(0, 100) <= 15)
	    		return false;
	    	return true;
	    }

		public override bool Shoot(Player player, Terraria.DataStructures.EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) {
			type = Mod.Find<ModProjectile>("DesertFlame").Type;
			return base.Shoot(player, source, position, velocity, type, damage, knockback);
		}
	}
}
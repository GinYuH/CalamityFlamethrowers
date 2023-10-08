using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Items
{
	public class Ichorthrower : ModItem
	{
		public override void SetStaticDefaults() {
			// DisplayName.SetDefault("Ichorthrower");
			// Tooltip.SetDefault("10% chance to not consume gel\nRapidly sprays flames imbued with Ichor\nA favorite of farmers for eliminating hungry pests");
		}

		public override void SetDefaults()
	    {
			Item.damage = 10;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 54;
			Item.height = 14;
			Item.useTime = 4;
			Item.useAnimation = 10;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true; //so the item's animation doesn't do damage
			Item.knockBack = 1.5f;
			Item.UseSound = SoundID.Item34;
			Item.shoot = Mod.Find<ModProjectile>("IchorFlame").Type;
			Item.value = 5000;
			Item.rare = 3;
			Item.autoReuse = true;
			Item.shootSpeed = 5.5f;
			Item.useAmmo = 23;
		}

		public override bool CanConsumeAmmo(Item ammo, Player player)
	    {
	    	if (Main.rand.Next(0, 100) <= 10)
	    		return false;
	    	return true;
	    }

		public override bool Shoot(Player player, Terraria.DataStructures.EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) {
			type = Mod.Find<ModProjectile>("IchorFlame").Type;
			return base.Shoot(player, source, position, velocity, type, damage, knockback);
		}
	}
}
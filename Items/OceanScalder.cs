using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Items
{
	public class OceanScalder : ModItem
	{
		public override void SetStaticDefaults() {
			// DisplayName.SetDefault("Ocean Scalder");
			// Tooltip.SetDefault("20% chance to not consume gel\nShoots a short ranged blast of powerful acidic flames\nThough it may scald water, it does not compare to the flames of the Brimstone Witch\nStill hot though.");
		}

		public override void SetDefaults()
	    {
			Item.damage = 45;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 54;
			Item.height = 14;
			Item.useTime = 6;
			Item.useAnimation = 18;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true; //so the item's animation doesn't do damage
			Item.knockBack = 1.0f;
			Item.UseSound = SoundID.Item34;
			Item.shoot = Mod.Find<ModProjectile>("AquaFlame").Type;
			Item.value = 5000;
			Item.rare = 4;
			Item.autoReuse = true;
			Item.shootSpeed = 6.0f;
			Item.useAmmo = 23;
		}

		public override bool CanConsumeAmmo(Item ammo, Player player)
	    {
	    	if (Main.rand.Next(0, 100) <= 20)
	    		return false;
	    	return true;
	    }

		public override bool Shoot(Player player, Terraria.DataStructures.EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) {
			type = Mod.Find<ModProjectile>("AquaFlame").Type;
			return base.Shoot(player, source, position, velocity, type, damage, knockback);
		}
	}
}
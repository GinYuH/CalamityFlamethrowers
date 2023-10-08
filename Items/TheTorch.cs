using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Items
{
	public class TheTorch : ModItem
	{
		public override void SetStaticDefaults() {
			// DisplayName.SetDefault("The Torch");
			// Tooltip.SetDefault("95% chance to not consume gel\nShoots out a massive jet of brimstone flames\nNeeds to be used while airborne as the earth below constrains it\nLay dormant for a thousand years, then strike with the fury of a thousand suns");
		}

		public override void SetDefaults()
	    {
			Item.damage = 666;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 54;
			Item.height = 14;
			Item.useTime = 160;
			Item.useAnimation = 80;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true; //so the item's animation doesn't do damage
			Item.knockBack = 6.5f;
			Item.UseSound = SoundID.Item34;
			Item.shoot = Mod.Find<ModProjectile>("BrimmyFlame").Type;
			Item.value = 5000;
			Item.rare = 4;
			Item.autoReuse = true;
			Item.shootSpeed = 10.5f;
			Item.useAmmo = 23;
		}

		public override bool CanConsumeAmmo(Item ammo, Player player)
	    {
	    	if (Main.rand.Next(0, 100) <= 95)
	    		return false;
	    	return true;
	    }

		public override bool Shoot(Player player, Terraria.DataStructures.EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) {
			type = Mod.Find<ModProjectile>("BrimmyFlame").Type;
			return base.Shoot(player, source, position, velocity, type, damage, knockback);
		}
	}
}
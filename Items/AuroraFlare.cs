using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Items
{
	public class AuroraFlare : ModItem
	{
		public override void SetStaticDefaults() {
			// DisplayName.SetDefault("Aurora Flare");
			// Tooltip.SetDefault("40% chance to not consume gel\nOccasionally lobs a sharp and deadly crystal\nSmaller than it was when it was alive for some reason...");
		}

		public override void SetDefaults()
	    {
			Item.damage = 85;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 54;
			Item.height = 14;
			Item.useTime = 16;
			Item.useAnimation = 19;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true; //so the item's animation doesn't do damage
			Item.knockBack = 1.5f;
			Item.UseSound = SoundID.Item34;
			Item.shoot = Mod.Find<ModProjectile>("AureusFlame").Type;
			Item.value = 5000;
			Item.rare = 6;
			Item.autoReuse = true;
			Item.shootSpeed = 7.5f;
			Item.useAmmo = 23;
		}

		public override bool CanConsumeAmmo(Item ammo, Player player)
	    {
	    	if (Main.rand.Next(0, 100) <= 40)
	    		return false;
	    	return true;
	    }

		public override bool Shoot(Player player, Terraria.DataStructures.EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            if (Main.rand.NextFloat() < 0.2f)
            {
                SoundEngine.PlaySound(SoundID.Item109, player.position);
                type = Mod.Find<ModProjectile>("AureusBomb").Type;
            }
            else 
            {
                type = Mod.Find<ModProjectile>("AureusFlame").Type;
			}
			Projectile.NewProjectile(Item.GetSource_FromAI(), position, velocity, type, damage, knockback);
			return false;
		}
	}
}
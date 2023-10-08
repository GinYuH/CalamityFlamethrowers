using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Items
{
	public class EffulgentZapper : ModItem
	{
		public override void SetStaticDefaults() {
			// DisplayName.SetDefault("Static Inferno");
			// Tooltip.SetDefault("75% chance to not consume gel\nOccasionally releases exploding birbs that blow up anything that moves! ... Even you!\nBird up!");
		}

		public override void SetDefaults()
	    {
			Item.damage = 285;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 54;
			Item.height = 14;
			Item.useTime = 16;
			Item.useAnimation = 19;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true; //so the item's animation doesn't do damage
			Item.knockBack = 1.5f;
			Item.UseSound = SoundID.Item34;
			Item.shoot = Mod.Find<ModProjectile>("BirbFlame").Type;
			Item.value = 5000;
			Item.rare = 11;
			Item.autoReuse = true;
			Item.shootSpeed = 2.5f;
			Item.useAmmo = 23;
		}

		public override bool CanConsumeAmmo(Item ammo, Player player)
	    {
	    	if (Main.rand.Next(0, 100) <= 75)
	    		return false;
	    	return true;
	    }

		public override bool Shoot(Player player, Terraria.DataStructures.EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            if (Main.rand.NextFloat() < 0.2f)
            {
                SoundEngine.PlaySound(SoundID.Item102, player.position);
                type = Mod.Find<ModProjectile>("Zap").Type;
            }
            else 
            {
                type = Mod.Find<ModProjectile>("BirbFlame").Type;
			}
			Projectile.NewProjectile(Item.GetSource_FromAI(), position, velocity, type, damage, knockback);
			return false;
		}
	}
}
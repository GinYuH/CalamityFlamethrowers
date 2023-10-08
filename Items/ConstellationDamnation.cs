using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace CalamityFlamethrowers.Items
{
	public class ConstellationDamnation : ModItem
	{
		public override void SetStaticDefaults() {
			// DisplayName.SetDefault("Meteor Shower");
			// Tooltip.SetDefault("55% chance to not consume gel\nFires a spray of bouncy flames\nConstellation damnation!");
		}

		public override void SetDefaults()
	    {
			Item.damage = 15;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 54;
			Item.height = 14;
			Item.useTime = 44;
			Item.useAnimation = 44;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true; //so the item's animation doesn't do damage
			Item.knockBack = 1.5f;
			Item.UseSound = SoundID.Item34;
			Item.shoot = Mod.Find<ModProjectile>("DeusBall").Type;
			Item.value = 5000;
			Item.rare = 9;
			Item.autoReuse = true;
			Item.shootSpeed = 20.0f;
			Item.useAmmo = 23;
		}

		public override bool CanConsumeAmmo(Item ammo, Player player)
	    {
	    	if (Main.rand.Next(0, 100) <= 55)
	    		return false;
	    	return true;
	    }

		public override bool Shoot(Player player, Terraria.DataStructures.EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Vector2 muzzleOffset = Vector2.Normalize(velocity) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
            type = Mod.Find<ModProjectile>("DeusBall").Type;
            int numberProjectiles = 10 + Main.rand.Next(1); // 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = velocity.RotatedByRandom(MathHelper.ToRadians(15)); // 30 degree spread.
				// If you want to randomize the speed to stagger the projectiles
				float scale = 1f - (Main.rand.NextFloat() * .3f);
				perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
			}
			return false;
            
        
		}
	}
}







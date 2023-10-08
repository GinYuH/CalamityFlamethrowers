using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Items
{
	public class RookofVengeance : ModItem
	{
		public override void SetStaticDefaults() {
			// DisplayName.SetDefault("Rook of Vengeance");
			// Tooltip.SetDefault("45% chance to not consume gel\nMay shoot out shrapnel instead of flames due to its weary state");
		}

		public override void SetDefaults()
	    {
			Item.damage = 165;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 54;
			Item.height = 14;
			Item.useTime = 19;
			Item.useAnimation = 19;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true; //so the item's animation doesn't do damage
			Item.knockBack = 1.5f;
			Item.UseSound = SoundID.Item34;
			Item.shoot = Mod.Find<ModProjectile>("RavagerFlame").Type;
			Item.value = 5000;
			Item.rare = 8;
			Item.autoReuse = true;
			Item.shootSpeed = 10.0f;
			Item.useAmmo = 23;
		}

		public override bool CanConsumeAmmo(Item ammo, Player player)
	    {
	    	if (Main.rand.Next(0, 100) <= 45)
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
            type = Main.rand.Next(new int[] { type, Mod.Find<ModProjectile>("Shrapnel").Type, Mod.Find<ModProjectile>("RavagerFlame").Type, Mod.Find<ModProjectile>("RavagerFlame").Type, Mod.Find<ModProjectile>("RavagerFlame").Type, Mod.Find<ModProjectile>("RavagerFlame").Type, Mod.Find<ModProjectile>("RavagerFlame").Type, Mod.Find<ModProjectile>("Nothing").Type});
            float numberProjectiles = 3 + Main.rand.Next(5); // 3, 4, or 5 shots
			float rotation = MathHelper.ToRadians(15);
			position += Vector2.Normalize(velocity) * 15f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = velocity.RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .8f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
			}
			return false;
            
        
		}
	}
}
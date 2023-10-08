using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Items
{
	public class SerpentsBreath : ModItem
	{
		public override void SetStaticDefaults() {
			// DisplayName.SetDefault("Serpent's Breath");
			// Tooltip.SetDefault("55% chance to not consume gel\nFires three streams of flame at once\nAttacks with the wrath of being forgotten");
		}

		public override void SetDefaults()
	    {
			Item.damage = 250;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 54;
			Item.height = 14;
			Item.useTime = 10;
			Item.useAnimation = 10;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true; //so the item's animation doesn't do damage
			Item.knockBack = 3.5f;
			Item.UseSound = SoundID.Item34;
			Item.shoot = Mod.Find<ModProjectile>("DonutFlame").Type;
            Item.rare = 11;
			Item.value = 5000;
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
           float numberProjectiles = 3;
			float rotation = MathHelper.ToRadians(45);
			position += Vector2.Normalize(velocity) * 45f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = velocity.RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
			}
			return false;
            
        
		}
	}
}
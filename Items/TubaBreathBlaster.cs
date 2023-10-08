using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Items
{
	public class TubaBreathBlaster : ModItem
	{
		public override void SetStaticDefaults() {
			// DisplayName.SetDefault("Tuna Breath Blaster");
			// Tooltip.SetDefault("50% chance to not consume gel\nLobs a storm of teeth and gunk along with gross flames\nYeah it probably wouldn't have been great to make fish tacos out of that beast");
		}

		public override void SetDefaults()
	    {
			Item.damage = 65;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 54;
			Item.height = 14;
			Item.useTime = 10;
			Item.useAnimation = 10;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true; //so the item's animation doesn't do damage
			Item.knockBack = 1.5f;
			Item.UseSound = SoundID.Item34;
			Item.shoot = Mod.Find<ModProjectile>("LeviFlame").Type;
			Item.value = 5000;
			Item.rare = 6;
			Item.autoReuse = true;
			Item.shootSpeed = 5.5f;
			Item.useAmmo = 23;
		}

		public override bool CanConsumeAmmo(Item ammo, Player player)
	    {
	    	if (Main.rand.Next(0, 100) <= 50)
	    		return false;
	    	return true;
	    }

		public override bool Shoot(Player player, Terraria.DataStructures.EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            if (Main.rand.NextFloat() < 0.1f)
            {
                SoundEngine.PlaySound(SoundID.Item112, player.position);
                type = Mod.Find<ModProjectile>("LeviGunk").Type;
            }
            else if (Main.rand.NextFloat() < 0.1f)
            {
                SoundEngine.PlaySound(SoundID.Item111, player.position);
                type = Mod.Find<ModProjectile>("LeviTooth").Type;
            }
            else 
            {
                type = Mod.Find<ModProjectile>("LeviFlame").Type;
            }
			Projectile.NewProjectile(Item.GetSource_FromAI(), position, velocity, type, damage, knockback);
			return false;
		}
	}
}
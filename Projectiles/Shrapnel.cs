using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Projectiles 
{
    public class Shrapnel : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Rook Shrapnel");
        }

        public override void SetDefaults()
		{
			Projectile.width = 24;
			Projectile.height = 24;
			Projectile.aiStyle = 41;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 2;
            Projectile.alpha = 1;
            Projectile.ignoreWater = true;
            Projectile.extraUpdates = 2;
            Projectile.timeLeft = 300;
            Projectile.usesLocalNPCImmunity = true;
            Projectile.localNPCHitCooldown = 1;
        }
         public override void AI()
        {
Projectile.ai[0] += 1f; // Use a timer to wait 15 ticks before applying gravity.
if (Projectile.ai[0] >= 15f)
{
	Projectile.ai[0] = 15f;
	Projectile.velocity.Y = Projectile.velocity.Y + 0.1f;
}
if (Projectile.velocity.Y > 16f)
{
	Projectile.velocity.Y = 16f;
};


        }

		}
    }


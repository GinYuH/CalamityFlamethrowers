using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace CalamityFlamethrowers.Projectiles 
{
    public class VoidFlame : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Void Flame");
        }

        public override void SetDefaults()
		{
			Projectile.width = 20;
			Projectile.height = 20;
			Projectile.aiStyle = -1;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 10;
            Projectile.alpha = 2551;
            Projectile.ignoreWater = true;
            Projectile.extraUpdates = 3;
            Projectile.timeLeft = 600;
            Projectile.usesLocalNPCImmunity = true;
            Projectile.localNPCHitCooldown = 1;
        }
         public override void AI()
        {
if (Main.rand.NextFloat() < 0.5f)
{
	int dust = Dust.NewDust(Projectile.position, 78, 73, 62, 0f, 0f, 0, new Color(255,255,255), 4.868421f);
	Main.dust[dust].noGravity = true;


};
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
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            if (Projectile.velocity.X != oldVelocity.X && Math.Abs(oldVelocity.X) > 1f) {
				Projectile.velocity.X = oldVelocity.X * -0.9f;
			}
			if (Projectile.velocity.Y != oldVelocity.Y && Math.Abs(oldVelocity.Y) > 1f) {
				Projectile.velocity.Y = oldVelocity.Y * -0.9f;
			}
			return false;
        }

public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff((ModLoader.GetMod("CalamityMod").Find<ModBuff>("Nightwither").Type), 300);
        }

		}
    }



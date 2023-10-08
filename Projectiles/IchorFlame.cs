using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Projectiles 
{
    public class IchorFlame : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Ichor Flame");
        }

        public override void SetDefaults()
		{
			Projectile.width = 15;
			Projectile.height = 15;
			Projectile.aiStyle = -1;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 2;
            Projectile.alpha = 255;
            Projectile.ignoreWater = true;
            Projectile.extraUpdates = 2;
            Projectile.timeLeft = 90;
        }
        public override void AI()
        {
if (Main.rand.NextFloat() < 0.5f)
{
	int dust = Dust.NewDust(Projectile.position, 52, 52, 107, 0f, 0f, 0, new Color(234,255,0), 1.118421f);
	Main.dust[dust].noGravity = true;

};


        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Projectile.Kill();
            return false;
        }

public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
        	target.AddBuff(BuffID.Ichor, 50);
        }

		}
    }

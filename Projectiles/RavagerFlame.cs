using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Projectiles 
{
    public class RavagerFlame : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Rook Flame");
        }

        public override void SetDefaults()
		{
			Projectile.width = 24;
			Projectile.height = 24;
			Projectile.aiStyle = -1;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 2;
            Projectile.alpha = 255;
            Projectile.ignoreWater = true;
            Projectile.extraUpdates = 3;
            Projectile.timeLeft = 60;
        }
         public override void AI()
        {
if (Main.rand.NextFloat() < 0.5f)
{
	int dust = Dust.NewDust(Projectile.position, 52, 47, 91, 0f, 0f, 0, new Color(0,255,242), 1.315789f);
	Main.dust[dust].noGravity = true;


};


        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Projectile.Kill();
            return false;
        }

		}
    }


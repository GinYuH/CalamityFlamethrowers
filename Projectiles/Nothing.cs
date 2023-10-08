using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Projectiles 
{
    public class Nothing : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("... wait how did you even die to this?");
        }

        public override void SetDefaults()
		{
			Projectile.width = 1;
			Projectile.height = 1;
			Projectile.aiStyle = -1;
			Projectile.friendly = true;
            Projectile.penetrate = 2;
            Projectile.alpha = 255;
            Projectile.ignoreWater = false;
            Projectile.extraUpdates = 1;
            Projectile.timeLeft = 1;
        }
         public override void AI()
        {
	int dust = Dust.NewDust(Projectile.position, 136, 136, 90, 0f, 0f, 0, new Color(255,0,0), 1.842105f);
	Main.dust[dust].noGravity = true;





        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Projectile.Kill();
            return false;
        }

		}
    }


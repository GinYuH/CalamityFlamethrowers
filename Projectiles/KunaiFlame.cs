using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Projectiles 
{
    public class KunaiFlame : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Flaming Kunai");
        }

        public override void SetDefaults()
		{
			Projectile.width = 24;
			Projectile.height = 24;
			Projectile.aiStyle = -1;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = -1;
            Projectile.alpha = 255;
            Projectile.ignoreWater = true;
            Projectile.extraUpdates = 5;
            Projectile.timeLeft = 900;
            Projectile.tileCollide = false;
        }
         public override void AI()
        {
if (Main.rand.NextFloat() < 0.1842105f)
{
	int dust = Dust.NewDust(Projectile.position, 78, 73, 62, 0f, 0f, 0, new Color(255,255,255), 4.868421f);
	Main.dust[dust].noGravity = true;


};


        }

		}
    }

using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Projectiles 
{
    public class BrimmyFlame : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Brimstone Flame");
        }

        public override void SetDefaults()
		{
			Projectile.width = 60;
			Projectile.height = 60;
			Projectile.aiStyle = -1;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 1;
            Projectile.alpha = 255;
            Projectile.ignoreWater = true;
            Projectile.extraUpdates = 8;
            Projectile.timeLeft = 140;
        }
        public override void AI()
        {
if (Main.rand.NextFloat() < 0.5f)
{
    int dust = Dust.NewDust(Projectile.position, 115, 136, 259, 0f, 0f, 0, new Color(255,0,25), 2.973684f);
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


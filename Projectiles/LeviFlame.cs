using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Projectiles 
{
    public class LeviFlame : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Ambergris Flame");
        }

        public override void SetDefaults()
		{
			Projectile.width = 20;
			Projectile.height = 20;
			Projectile.aiStyle = -1;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 1;
            Projectile.alpha = 255;
            Projectile.ignoreWater = true;
            Projectile.extraUpdates = 1;
            Projectile.timeLeft = 80;
        }
        public override void AI()
        {
if (Main.rand.NextFloat() < 0.5f)
{
	// You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
    int dust = Dust.NewDust(Projectile.position, 42, 52, 1, 0f, 0f, 0, new Color(0,255,67), 1.644737f);
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

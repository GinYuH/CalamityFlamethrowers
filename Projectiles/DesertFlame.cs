using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Projectiles 
{
    public class DesertFlame : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Desert Flame");
        }

        public override void SetDefaults()
		{
			Projectile.width = 8;
			Projectile.height = 8;
			Projectile.aiStyle = -1;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = -1;
            Projectile.alpha = 255;
            Projectile.ignoreWater = true;
            Projectile.extraUpdates = 3;
            Projectile.timeLeft = 30;
        }
        public override void AI()
        {
if (Main.rand.NextFloat() < 0.5f)
{
	Dust dust;
    int choice = Main.rand.Next(3); 
	if (choice == 0) 
	{
		choice = 15;
	}
	else if (choice == 1)
	{
		choice = 57;
	}
	else
	{
		choice = 58;
	}
	// You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
    Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, choice, Projectile.velocity.X * 0.25f, Projectile.velocity.Y * 0.25f, 150, new Color(255,0,25), 0.8552632f);
};
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Projectile.Kill();
            return false;
        }

public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
        	target.AddBuff(BuffID.OnFire, 100);
        }

		}
    }

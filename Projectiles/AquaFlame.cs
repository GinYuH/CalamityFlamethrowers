using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Projectiles 
{
    public class AquaFlame : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Acidic Flame");
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
            Projectile.extraUpdates = 4;
            Projectile.timeLeft = 45;
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
    Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, choice, Projectile.velocity.X * 0.25f, Projectile.velocity.Y * 0.25f, 150, new Color(159,255,0), 0.8552632f);
};
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Projectile.Kill();
            return false;
        }

public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
        	target.AddBuff((ModLoader.GetMod("CalamityMod").Find<ModBuff>("SulphuricPoisoning").Type), 300);
        }

		}
    }

	//Dust dust;
	// You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
	//Vector2 position = Main.LocalPlayer.Center;
	//dust = Main.dust[Terraria.Dust.NewDust(position, 47, 52, 1, 0f, 0f, 0, new Color(159,255,0), 1f)];
	//dust.noGravity = true;

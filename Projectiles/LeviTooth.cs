using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Projectiles 
{
    public class LeviTooth : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Leviathan Tooth");
        }

        public override void SetDefaults()
		{
			Projectile.width = 24;
			Projectile.height = 24;
			Projectile.aiStyle = -1;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 10;
            Projectile.alpha = 1;
            Projectile.ignoreWater = false;
            Projectile.extraUpdates = 5;
            Projectile.timeLeft = 900;
        }
         public override void AI()
        {
if (Main.rand.NextFloat() < 0.1842105f)
{
	int dust = Dust.NewDust(Projectile.position, 42, 52, 1, 0f, 0f, 0, new Color(84,255,0), 1.644737f);
	Main.dust[dust].noGravity = true;


};


        }

		}
    }




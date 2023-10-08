using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Projectiles 
{
    public class AureusFlame : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Astral Flame");
        }

        public override void SetDefaults()
		{
			Projectile.width = 24;
			Projectile.height = 24;
			Projectile.aiStyle = -1;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 3;
            Projectile.alpha = 255;
            Projectile.ignoreWater = true;
            Projectile.extraUpdates = 5;
            Projectile.timeLeft = 90;
        }
         public override void AI()
        {
if (Main.rand.NextFloat() < 0.5f)
{
	int dust = Dust.NewDust(Projectile.position, 26, 26, 55, 0.2631581f, 0f, 73, new Color(255,125,0), 1.644737f);
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
        	target.AddBuff((ModLoader.GetMod("CalamityMod").Find<ModBuff>("AstralInfectionDebuff").Type), 100);
        }

		}
    }

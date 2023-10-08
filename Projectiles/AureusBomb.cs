using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Projectiles 
{
    public class AureusBomb : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Astral Gem");
        }

        public override void SetDefaults()
		{
			Projectile.width = 36;
			Projectile.height = 36;
			Projectile.aiStyle = -1;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = -1;
            Projectile.alpha = 15;
            Projectile.ignoreWater = true;
            Projectile.extraUpdates = 5;
            Projectile.timeLeft = 900;
            Projectile.spriteDirection = Projectile.direction;
        }
         public override void AI()
        {
if (Main.rand.NextFloat() < 0.5f)
{
	int dust = Dust.NewDust(Projectile.position, 57, 68, 55, 0f, 0f, 0, new Color(0,167,255), 0.9210526f);
	Main.dust[dust].noGravity = true;


}


        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Projectile.Kill();
            SoundEngine.PlaySound(SoundID.Item49, Projectile.position);
            return false;
        }

public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
        	target.AddBuff((ModLoader.GetMod("CalamityMod").Find<ModBuff>("AstralInfectionDebuff").Type), 600);
            target.AddBuff(BuffID.Ichor, 300);
            SoundEngine.PlaySound(SoundID.Item27, Projectile.position);
            Projectile.Kill();
        }

		}
    }




using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Projectiles 
{
    public class Zap : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Birb Zap");
        Main.projFrames[Projectile.type] = 5;

        }

        public override void SetDefaults()
		{
			Projectile.width = 12;
			Projectile.height = 12;
			Projectile.aiStyle = 16;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = -1;
            AIType = 340;
            Projectile.scale = 0.7f;
            Projectile.alpha = 1;
            Projectile.ignoreWater = true;
            Projectile.timeLeft = 900;
        }

 public override void AI()
        {
            if (Main.rand.NextFloat() < 0.5f)
{
	int dust = Dust.NewDust(Projectile.position, 42, 42, 163, 0f, 0f, 0, new Color(255,251,0), 2.171053f);
	Main.dust[dust].noGravity = true;


};
if (++Projectile.frameCounter >= 6)
{
	Projectile.frameCounter = 0;
	if (++Projectile.frame >= Main.projFrames[Projectile.type])
	{
		Projectile.frame = 0;
	}
}
        }


public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
        	target.AddBuff((ModLoader.GetMod("CalamityMod").Find<ModBuff>("HolyFlames").Type), 100);
            SoundEngine.PlaySound(SoundID.Item55, Projectile.Center); // Play a death sound
			Vector2 usePos = Projectile.position; // Position to use for dusts
			
			// Please note the usage of MathHelper, please use this!
			// We subtract 90 degrees as radians to the rotation vector to offset the sprite as its default rotation in the sprite isn't aligned properly.
			Vector2 rotVector = (Projectile.rotation - MathHelper.ToRadians(90f)).ToRotationVector2(); // rotation vector to use for dust velocity
			usePos += rotVector * 16f;

			// Declaring a constant in-line is fine as it will be optimized by the compiler
			// It is however recommended to define it outside method scope if used elswhere as well
			// They are useful to make numbers that don't change more descriptive
			const int NUM_DUSTS = 20;

			// Spawn some dusts upon javelin death
			for (int i = 0; i < NUM_DUSTS; i++) {
				// Create a new dust
				Dust dust = Dust.NewDustDirect(usePos, Projectile.width, Projectile.height, 81114, 0f, 0f, 0, new Color(234,255,0), 3.157895f);
                Dust.NewDustDirect(usePos, Projectile.width, Projectile.height, 81114, 0f, 0f, 0, new Color(234,255,0), 3.157895f);
               Dust.NewDustDirect(usePos, Projectile.width, Projectile.height, 81114, 0f, 0f, 0, new Color(234,255,0), 3.157895f);
                Dust.NewDustDirect(usePos, Projectile.width, Projectile.height, 81114, 0f, 0f, 0, new Color(234,255,0), 3.157895f);
              Dust.NewDustDirect(usePos, Projectile.width, Projectile.height, 81114, 0f, 0f, 0, new Color(234,255,0), 3.157895f);
                Dust.NewDustDirect(usePos, Projectile.width, Projectile.height, 81114, 0f, 0f, 0, new Color(234,255,0), 3.157895f);
                Dust.NewDustDirect(usePos, Projectile.width, Projectile.height, 81114, 0f, 0f, 0, new Color(234,255,0), 3.157895f);
                Dust.NewDustDirect(usePos, Projectile.width, Projectile.height, 81114, 0f, 0f, 0, new Color(234,255,0), 3.157895f);
                Dust.NewDustDirect(usePos, Projectile.width, Projectile.height, 81114, 0f, 0f, 0, new Color(234,255,0), 3.157895f);
                Dust.NewDustDirect(usePos, Projectile.width, Projectile.height, 81114, 0f, 0f, 0, new Color(234,255,0), 3.157895f);
				dust.position = (dust.position + Projectile.Center) / 2f;
				dust.velocity += rotVector * 2f;
				dust.velocity *= 0.5f;
				dust.noGravity = true;
				usePos -= rotVector * 8f;

        }}

        
        }

		}
    




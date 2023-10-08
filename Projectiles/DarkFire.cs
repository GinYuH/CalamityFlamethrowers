using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Projectiles 
{
    public class DarkFire : ModProjectile
    {
        public override string Texture => "CalamityMod/Projectiles/InvisibleProj";
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Dark Fire");
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
            Projectile.timeLeft = 240;
            Projectile.tileCollide = false;
            Projectile.usesLocalNPCImmunity = true;
            Projectile.localNPCHitCooldown = 5;
        }
         public override void AI()
        {
            Projectile.ai[0]++;
            if (Projectile.ai[0] >= 12)
            {
                Projectile.NewProjectile(Projectile.GetSource_FromAI(), Projectile.Center.X, Projectile.Center.Y + 1200, 0, -10, ModContent.ProjectileType<DarkFireSplit>(), Projectile.damage, 0f, Projectile.owner, 0, 1);
                Projectile.ai[0] = 0;
            }
            for (int counter = 0; counter <= 2; counter++)
            {
                int dust = Dust.NewDust(Projectile.position, 26, 26, 65, 0.2631581f, 0f, 65, default(Color), 3f);
                Main.dust[dust].noGravity = true;
            }
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            return false;
        }

public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
        	target.AddBuff((ModLoader.GetMod("CalamityMod").Find<ModBuff>("DemonFlames").Type), 100);
        }

		}
    }

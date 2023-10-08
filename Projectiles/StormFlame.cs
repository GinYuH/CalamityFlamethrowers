
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Projectiles 
{
    public class StormFlame : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Storm Flame");
            ProjectileID.Sets.CultistIsResistantTo[Projectile.type] = true;
        }

        public override void SetDefaults()
		{
			Projectile.width = 20;
			Projectile.height = 20;
			Projectile.aiStyle = -1;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 3;
            Projectile.alpha = 255;
            Projectile.ignoreWater = true;
            Projectile.extraUpdates = 3;
            Projectile.timeLeft = 230;
            Projectile.tileCollide = false;
        }
         public override void AI()
        {
if (Main.rand.NextFloat() < 0.5f)
{
	int dust = Dust.NewDust(Projectile.position, 52, 57, 62, 0f, 0f, 0, new Color(255,255,255), 2.894737f);
	Main.dust[dust].noGravity = true;


};


        }

public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
        	target.AddBuff((ModLoader.GetMod("CalamityMod").Find<ModBuff>("Nightwither").Type), 300);
            target.AddBuff((ModLoader.GetMod("CalamityMod").Find<ModBuff>("AstralInfectionDebuff").Type), 400);
            target.AddBuff((ModLoader.GetMod("CalamityMod").Find<ModBuff>("GodSlayerInferno").Type), 200);
        }

		}
    }




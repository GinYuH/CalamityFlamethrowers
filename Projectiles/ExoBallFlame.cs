using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Projectiles 
{
    public class ExoBallFlame : ModProjectile
    {
        public override string Texture => "CalamityMod/Projectiles/InvisibleProj";
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Exo Ball Flame");
        }

        public override void SetDefaults()
		{
			Projectile.width = 40;
			Projectile.height = 40;
			Projectile.aiStyle = -1;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 1;
            Projectile.alpha = 255;
            Projectile.ignoreWater = true;
            //projectile.extraUpdates = 3;
            Projectile.timeLeft = 180;
        }
        public override void AI()
        {
            int firetype = Main.rand.NextBool(2) ? 107 : 234;
            for (int counter = 0; counter < 2; counter++)
            {
                int dusty = Dust.NewDust(new Vector2(Projectile.position.X, Projectile.position.Y), Projectile.width, Projectile.height, firetype, Projectile.velocity.X * 0.2f, Projectile.velocity.Y * 0.2f, 100, default, 0.6f);
                Dust dustyy = Main.dust[dusty];
                dustyy.noGravity = true;
            }
            if (Main.rand.Next(20) == 0 && Projectile.timeLeft < 140)
            {
                float numberProjectiles = 8;
                float rotation = MathHelper.ToRadians(180);
                //projectile.position += Vector2.Normalize(new Vector2(projectile.velocity.X, projectile.velocity.Y)) * 180f;
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(Projectile.velocity.X, Projectile.velocity.Y).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f;
                    Projectile.NewProjectile(Projectile.GetSource_FromAI(), Projectile.position.X, Projectile.position.Y, perturbedSpeed.X * Main.rand.Next(-4, 4), perturbedSpeed.Y * Main.rand.Next(-4, 4), ModLoader.GetMod("CalamityMod").Find<ModProjectile>("ExoFire").Type, Projectile.damage, Projectile.knockBack, Projectile.owner);
                }
            }
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Projectile.Kill();
            return false;
        }
	}
}

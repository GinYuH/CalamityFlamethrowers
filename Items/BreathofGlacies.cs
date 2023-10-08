using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityFlamethrowers.Items
{
	public class BreathofGlacies : ModItem
	{
		public override void SetStaticDefaults() {
			// DisplayName.SetDefault("Breath of Glacies");
			// Tooltip.SetDefault("35% chance to not consume gel\nRapidly fires a barrage of cold flames with high range\nWho cares if it's scientifically inaccurate");
		}

		public override void SetDefaults()
	    {
			Item.damage = 8;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 54;
			Item.height = 14;
			Item.useTime = 2;
			Item.useAnimation = 2;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true; //so the item's animation doesn't do damage
			Item.knockBack = 1.5f;
			Item.UseSound = SoundID.Item34;
			Item.shoot = Mod.Find<ModProjectile>("FrostFlame").Type;
			Item.value = 5000;
			Item.rare = 4;
			Item.autoReuse = true;
			Item.shootSpeed = 7.5f;
			Item.useAmmo = 23;
		}

        public override bool CanConsumeAmmo(Item ammo, Player player)
		{
			if (Main.rand.Next(0, 100) <= 35)
				return false;
			return true;
		}

        public override bool Shoot(Player player, Terraria.DataStructures.EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            type = Mod.Find<ModProjectile>("FrostFlame").Type;
			return base.Shoot(player, source, position, velocity, type, damage, knockback);
		}
	}
}
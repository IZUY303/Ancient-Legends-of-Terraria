using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftMaxedHacks.Items.Weapons
{
    public class ShotGun : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Great Shark";
            item.damage = 124;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.toolTip = "40% shark 60% gun.";
            item.toolTip2 = "85% chance to not consuming ammo";
            item.toolTip2 = "Giant burst,Consumes alot of ammo";
            item.useTime = 20;
            item.useAnimation = 38;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 7;
            item.value = 10000;
            item.rare = 2;
			item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 10; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 1f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() > .85f;

		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 4 + Main.rand.Next(2); // 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false; // return false because we don't want tmodloader to shoot projectile
		}
    }
}
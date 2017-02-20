using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftMaxedHacks.Elementals.Items
{
	public class MythicalSword2 : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Mythical Excalibur";
			item.damage = 276;
			item.melee = true;
			item.width = 44;
			item.height = 44;
			item.toolTip = "Element:Mythical";
			item.toolTip2 = "Shoots random Projectiles";
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.shootSpeed = 16f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MythicalSword1" ,2);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Sparkle"));
			}
		}
		public override bool UseItem(Player player)
		{
			if (Main.rand.Next(7) == 0)
				item.shoot = 132;
			if (Main.rand.Next(5) == 0)
				item.shoot = 156;
			if (Main.rand.Next(5) == 0)
				item.shoot = 157;
			if (Main.rand.Next(3) == 0)
				item.shoot = 173;
			if (Main.rand.Next(6) == 0)
				item.shoot = 405;
			else
				item.shoot = 116;
			return true;
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.MoonLeech, 1);
		}
	}
}
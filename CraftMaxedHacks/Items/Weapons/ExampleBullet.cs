using Terraria.ID;
using Terraria.ModLoader;

namespace CraftMaxedHacks.Items.Weapons
{
	public class ExampleBullet : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Giant Bullet";
			item.damage = 34;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.toolTip = "High damage.";
			item.consumable = true;
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("ExampleBullet");
			item.shootSpeed = 16f;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MusketBall, 50);
			recipe.AddIngredient(null, "ExampleItem", 1);
			recipe.AddTile(null, "ExampleWorkbench");
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
using Terraria.ModLoader;

namespace CraftMaxedHacks.Items
{
	public class SummonerItem : ModItem
	{
		public override void SetDefaults()
		{
			base.SetDefaults();
			item.name = "Summoner Item";
			item.toolTip = "Used to craft boss summoning Item";
			item.toolTip2 = "Handle with Care";
			item.maxStack = 999;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ExampleItem");
			recipe.AddTile(mod, "ExampleWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("CraftMaxedHacks:Materials", 1);
			recipe.AddTile(mod, "ExampleWorkbench");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
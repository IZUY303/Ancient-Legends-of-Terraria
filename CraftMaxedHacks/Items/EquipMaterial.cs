using Terraria.ModLoader;

namespace CraftMaxedHacks.Items
{
	public class EquipMaterial : ExampleItem
	{
		public override void SetDefaults()
		{
			base.SetDefaults();
			item.name = "Equipment Item";
			item.toolTip = "Used to craft equipment";
			item.toolTip2 = "";
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
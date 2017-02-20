using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftMaxedHacks
{
	public static class RecipeHelper
	{
		public static void AddBossRecipes(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SummonerItem", 10);
			recipe.AddTile(null, "ExampleWorkbench");
			recipe.SetResult(ItemID.SuspiciousLookingEye, 5);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SummonerItem", 10);
			recipe.AddTile(null, "ExampleWorkbench");
			recipe.SetResult(ItemID.WormFood, 5);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SummonerItem", 10);
			recipe.AddTile(null, "ExampleWorkbench");
			recipe.SetResult(ItemID.BloodySpine, 5);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SummonerItem", 10);
			recipe.AddTile(null, "ExampleWorkbench");
			recipe.SetResult(ItemID.Abeemination, 10);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SummonerItem", 10);
			recipe.AddTile(null, "ExampleWorkbench");
			recipe.SetResult(ItemID.GuideVoodooDoll);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SummonerItem", 10);
			recipe.AddTile(null, "ExampleWorkbench");
			recipe.SetResult(ItemID.MechanicalEye, 3);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SummonerItem", 10);
			recipe.AddTile(null, "ExampleWorkbench");
			recipe.SetResult(ItemID.MechanicalWorm, 3);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SummonerItem", 10);
			recipe.AddTile(null, "ExampleWorkbench");
			recipe.SetResult(ItemID.MechanicalSkull, 3);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SummonerItem", 10);
			recipe.AddTile(null, "ExampleWorkbench");
			recipe.SetResult(ItemID.LihzahrdPowerCell, 1);
			recipe.AddRecipe();
		}

		public static void TestRecipeEditor(Mod mod)
		{
			RecipeFinder finder = new RecipeFinder();
			finder.AddIngredient(ItemID.Chain);
			foreach (Recipe recipe in finder.SearchRecipes())
			{
				RecipeEditor editor = new RecipeEditor(recipe);
				editor.DeleteIngredient(ItemID.Chain);
			}

			finder = new RecipeFinder();
			finder.AddRecipeGroup("IronBar");
			finder.AddTile(TileID.Anvils);
			finder.SetResult(ItemID.Chain, 10);
			Recipe recipe2 = finder.FindExactRecipe();
			if (recipe2 != null)
			{
				RecipeEditor editor = new RecipeEditor(recipe2);
				editor.DeleteRecipe();
			}
		}
	}
}
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftMaxedHacks.Items.Placeable
{
	public class ExampleWorkbench : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Ancient Forge";
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			AddTooltip("This is an old forge");
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("ExampleWorkbench");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Hellforge);
			recipe.AddIngredient(mod, "ItemName", 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
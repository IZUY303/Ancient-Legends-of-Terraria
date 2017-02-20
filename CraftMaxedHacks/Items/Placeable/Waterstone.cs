using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftMaxedHacks.Items.Placeable
{
    public class Waterstone : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Waterstone";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            AddTooltip("Not Ebon,Crim,Plearl its water");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("Waterstone"); //put your CustomBlock Tile name
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 10);   //you need 10 Wood
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

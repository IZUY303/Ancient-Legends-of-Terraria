using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftMaxedHacks.Items
{
    public class ItemName : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Fluffy Toy";
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            AddTooltip("'You are both EVIL and GOOD!");
            item.value = 100;
            item.rare = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

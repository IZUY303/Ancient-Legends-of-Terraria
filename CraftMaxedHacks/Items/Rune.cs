using System;
using Microsoft.Xna.Framework;
using Terraria.GameContent.UI;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftMaxedHacks.Items       //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    public class Rune : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Rusty Runes";   //the name displayed when hovering over the item ingame.
            item.width = 23;   //The size in width of the sprite in pixels.
            item.height = 23;   //The size in height of the sprite in pixels.
            item.maxStack = 999; //This defines the items max stack
            AddTooltip("Old runes this might be something which shaman talks about"); //The description of the item shown when hovering over the item ingame.
            item.value = Item.buyPrice(0, 1, 20, 50); //	How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10 gold and to sell it its 2 gold)
            item.rare = -12;    //The color the title of your Weapon when hovering over it ingame . -12 is the expert rainbow like the treasure bags color  .
        }
        public override void AddRecipes()   //This defines the crafting recepe for this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 25); //this is how to add an ingredient from Terraria,  so for crafting this item you need 2 gold coin
            recipe.AddIngredient(ItemID.GoldCoin, 2); //this is how to add an ingredient from Terraria,  so for crafting this item you need 2 gold coin      		      		
            recipe.AddTile(TileID.DemonAltar);   //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
            recipe.SetResult(this, 1);   //this defines the resultat of the crafting so 1 Custom Currency
            recipe.AddRecipe();
        }
    }
}

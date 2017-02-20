using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CraftMaxedHacks.Items.Armor
{
	public class ExampleLeggings : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Legs);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Light slippers";
			item.width = 18;
			item.height = 18;
			AddTooltip("You wears the Light Side.");
			AddTooltip2("Insane movements");
			item.value = 10000;
			item.rare = 10;
			item.defense = 40;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 5.99f;
			player.statManaMax2 += 400;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "EquipMaterial", 45);
			recipe.AddTile(null, "ExampleWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
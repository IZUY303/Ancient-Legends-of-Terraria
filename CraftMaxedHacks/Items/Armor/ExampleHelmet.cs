using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CraftMaxedHacks.Items.Armor
{
	public class ExampleHelmet : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Light Crown";
			item.width = 18;
			item.height = 18;
			item.toolTip = "Hollow loves you.";
			item.value = 10000;
			item.rare = 10;
			item.defense = 45;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("ExampleBreastplate") && legs.type == mod.ItemType("ExampleLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Major damage increase";
			player.meleeDamage += 0.5f;
			player.thrownDamage += 0.5f;
			player.rangedDamage += 0.5f;
			player.magicDamage += 0.5f;
			player.minionDamage += 0.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "EquipMaterial", 30);
			recipe.AddTile(null, "ExampleWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
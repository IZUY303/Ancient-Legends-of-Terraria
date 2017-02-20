using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CraftMaxedHacks.Items
{
	public class ExampleShield : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Shield);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Illuminious Utlity Trousers";
			item.width = 24;
			item.height = 28;
			item.toolTip = "Greatly increase damage and life regen.";
			item.toolTip2 = "A part of Yeyint's accessories";
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
			item.defense = 25;
			item.lifeRegen = 50;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeDamage += 0.5f;
			player.thrownDamage += 0.5f;
			player.rangedDamage += 0.5f;
			player.magicDamage += 0.5f;
			player.minionDamage += 0.5f;
			player.endurance = 1f - 0.1f * (1f - player.endurance);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "EquipMaterial", 60);
			recipe.AddTile(null, "ExampleWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
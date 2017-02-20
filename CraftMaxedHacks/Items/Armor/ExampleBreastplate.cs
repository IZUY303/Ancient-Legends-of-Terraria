using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftMaxedHacks.Items.Armor
{
	public class ExampleBreastplate : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Body);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Light TShirt";
			item.width = 18;
			item.height = 18;
			AddTooltip("Purple Bows to you.");
			AddTooltip2("Immunity to major debuffs");
			AddTooltip2("Increases speed and life");
			item.value = 10000;
			item.rare = 10;
			item.defense = 60;
		}
		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.buffImmune[BuffID.Ichor] = true;
			player.buffImmune[BuffID.Cursed] = true;
			player.buffImmune[BuffID.Darkness] = true;
			player.buffImmune[BuffID.MoonLeech] = true;
			player.buffImmune[BuffID.PotionSickness] = true;
			player.buffImmune[BuffID.CursedInferno] = true;
			player.buffImmune[BuffID.TheTongue] = true;
			player.statLifeMax2 += 2000;
			player.maxMinions++;
			player.maxMinions++;
			player.maxMinions++;
			player.maxMinions++;
			player.maxMinions++;
			player.maxMinions++;
			player.maxMinions++;
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
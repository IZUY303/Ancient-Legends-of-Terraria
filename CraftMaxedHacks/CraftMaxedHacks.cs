using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.UI;
using CraftMaxedHacks.Items;

namespace CraftMaxedHacks
{
    public class CraftMaxedHacks : Mod
    {
        public static int CustomCurrencyID;

        public CraftMaxedHacks()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true,
                AutoloadBackgrounds = true
            };
        }
        public override void Load()
        {
            CustomCurrencyID = CustomCurrencyManager.RegisterCurrency(new CustomCurrencyData(ItemType("Rune"), 999L));  //this defines the item Currency, so CustomCurrencyItem now is a Currency
        }
		public override void UpdateMusic(ref int music)
        {
			
			if (Main.LocalPlayer.active && Main.LocalPlayer.GetModPlayer<CMHPlayer>(this).ZoneCorruptionII)
			{
				music = MusicID.Title;
			}
        }

		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " " + GetItem("ExampleItem").item.name, new int[]
			{
				ItemType("ExampleItem"),
				ItemType("EquipMaterial"),
				ItemType("SummonerItem")
			});
			RecipeGroup.RegisterGroup("CraftMaxedHacks:Materials", group);
		}
    }
}


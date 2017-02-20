using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftMaxedHacks.Items.Weapons   //where is located
{
    public class YeyintSaber : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Illuminious Lightsabre";     //Sword name
            item.damage = 1000;            //Sword damage
            item.melee = true;            //if it's melee
            item.width = 220;              //Sword width
            item.height = 220;             //Sword height
            item.toolTip = "Legendary Multi-Bladed Weapon,Forged by the Light Side";  //Item Description
            item.toolTip2 = "Forces will move from up to down and damage everything in path";  //Item Description
            item.useTime = 10;          //how fast 
            item.useAnimation = 25; 
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;			
            item.useStyle = 100;        //Style is how this item is used, 1 is the style of the sword
            item.knockBack = 5;      //Sword knockback
            item.value = 1000000;        
            item.rare = 10;
            item.autoReuse = false;   //if it's capable of autoswing.
            item.useTurn = true;
            item.shoot = mod.ProjectileType("DanceOfBlades");
            item.shootSpeed = 0f;                //projectile speed	
        }
        public override void AddRecipes()  //How to craft this sword
        {
            ModRecipe recipe = new ModRecipe(mod);      
            recipe.AddIngredient(mod, "ItemName", 3);   //you need 1 DirtBlock      
            recipe.AddIngredient(mod, "ExampleItem", 15);
            recipe.AddTile(mod, "ExampleWorkbench");   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();

        }

		public override bool UseItemFrame(Player player)
		{
			player.bodyFrame.Y = 3 * player.bodyFrame.Height;
			return true;
		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            player.AddBuff(mod.BuffType("BuffName"), 400);  //400 is the buff time
        }
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(1) == 0)
            {
                int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Force"));
            }
        }
    }
}
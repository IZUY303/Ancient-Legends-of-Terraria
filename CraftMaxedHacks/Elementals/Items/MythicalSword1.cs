using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftMaxedHacks.Elementals.Items
{
	public class MythicalSword1 : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Mythical Sword";
			item.damage = 135;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.toolTip = "Element:Mythical";
			item.toolTip2 = "Buffes enemies with random buffes";
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
		}
		public override void OnHitPvp(Player player, Player target, int damage, bool crit)
		{
			if (Main.rand.Next(3) == 0)
			{
				target.AddBuff(BuffID.OnFire, 10);
			}
			else if (Main.rand.Next(7) == 0)
			{
				target.AddBuff(BuffID.MoonLeech, 10);
			}
			else if (Main.rand.Next(5) == 0)
			{
				target.AddBuff(BuffID.Frostburn, 10);
			}
			else if (Main.rand.Next(4) == 0)
			{
				target.AddBuff(BuffID.Ichor, 10);
			}
			else if (Main.rand.Next(5) == 0)
			{
				target.AddBuff(BuffID.CursedInferno, 10);
			}
			else
			{
				target.AddBuff(BuffID.Stoned, 3);
			}
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			if (Main.rand.Next(3) == 0)
			{
				target.AddBuff(BuffID.OnFire, 10);
			}
			else if (Main.rand.Next(7) == 0)
			{
				target.AddBuff(BuffID.MoonLeech, 10);
			}
			else if (Main.rand.Next(5) == 0)
			{
				target.AddBuff(BuffID.Frostburn, 10);
			}
			else if (Main.rand.Next(4) == 0)
			{
				target.AddBuff(BuffID.Ichor, 10);
			}
			else if (Main.rand.Next(5) == 0)
			{
				target.AddBuff(BuffID.CursedInferno, 10);
			}
			else
			{
				target.AddBuff(BuffID.Stoned, 3);
			}
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Sparkle"));
			}
		}
	}
}
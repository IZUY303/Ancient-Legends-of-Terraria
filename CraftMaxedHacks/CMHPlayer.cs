using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftMaxedHacks
{
	public class CMHPlayer : ModPlayer
	{

		public bool ZoneCorruptionII = false;

		public override void UpdateBiomes()
		{
			ZoneCorruptionII = (CMHWorld.WaterBlocks > 50);
		}

		public override bool CustomBiomesMatch(Player other)
		{
			CMHPlayer modOther = other.GetModPlayer<CMHPlayer>(mod);
			return ZoneCorruptionII == modOther.ZoneCorruptionII;
		}

		public override void CopyCustomBiomesTo(Player other)
		{
			CMHPlayer modOther = other.GetModPlayer<CMHPlayer>(mod);
			modOther.ZoneCorruptionII = ZoneCorruptionII;
		}

		public override void SendCustomBiomes(BinaryWriter writer)
		{
			byte flags = 0;
			if (ZoneCorruptionII)
			{
				flags |= 1;
			}
			writer.Write(flags);
		}

		public override void ReceiveCustomBiomes(BinaryReader reader)
		{
			byte flags = reader.ReadByte();
			ZoneCorruptionII = ((flags & 1) == 1);
		}
		public override Texture2D GetMapBackgroundImage()
		{
			if (ZoneCorruptionII)
			{
				return mod.GetTexture("CorruptionII_Map");
			}
			return null;
		}
	}
}

using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftMaxedHacks.NPCs
{
    public class NPCTown : ModNPC
    {
        public override bool Autoload(ref string name, ref string texture, ref string[] altTextures)
        {
            name = "Shaman";            
            return mod.Properties.Autoload;
        }
        public override void SetDefaults()
        {
            npc.name = "Shaman";
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 15;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            Main.npcFrameCount[npc.type] = 25;            
            animationType = NPCID.Guide;
        }
        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
			
            return false;// this make that he will spawn when a house is available
        }



        public override string TownNPCName()
        {										//NPC names
            switch (WorldGen.genRand.Next(4))
            {
                case 0:
                    return "Bonzo";
                case 1:
                    return "Biomest";
                case 2:
                    return "Bluster";
                default:
                    return "Shrater";
            }
        }




        public override string GetChat()
        { 											//npc chat 
          
            switch (Main.rand.Next(3))
            {
                case 0:
                    return "Have you seen the moon during day,I bet you don't!";
                case 1:
                    return "Selling Runes....aaa I meaan Buying Runes";
                case 2:
                    return "They say there is a toy or a doll that is powerful";
                case 3:
                    return "Buy something!Ancient Gods' order!";
                case 4:
                    return "Cultists I have a trrreaty...I mmeann Die";
                default:
                    return "Selling World Corruptions!Wait did you hear I sell waterstone";
            }
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Lang.inter[28];
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {
                shop = true;
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(mod.ItemType("Rune"));      //this defines what item to sell .          
            nextSlot++;
			if (Main.LocalPlayer.GetModPlayer<CMHPlayer>(mod).ZoneCorruptionII)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("Waterstone"));
				nextSlot++;
			}
			if (Main.moonPhase < 4 && Main.hardMode)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("FireAquaSword"));
				nextSlot++;
			}
			else if (Main.moonPhase < 6 && Main.hardMode)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("MythicalSword1"));
				nextSlot++;
				shop.item[nextSlot].SetDefaults(mod.ItemType("GatliFire"));
				nextSlot++;
			}
			else if (Main.moonPhase < 8 && Main.hardMode)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("MythicalSword2"));
				nextSlot++;
			}
			else
			{
			}
        }  

    }
}
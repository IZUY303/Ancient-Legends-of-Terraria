using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftMaxedHacks.NPCs.Boss
{
    public class KingSharkneon : ModNPC
    {
		private int delay = 0; //start of with 0
		private const int progress = 0;
        public override void SetDefaults()
        {
			Main.npcFrameCount[npc.type] = 2;
            animationType = NPCID.DemonEye;   //this boss will animate like the Demon Eye monster
            npc.lifeMax = 500000;   //boss life
            npc.knockBackResist = 0f;		//make boss invunerable to knockback
            npc.width = 392;
            npc.height = 390;
            npc.value = Item.buyPrice(0, 40, 75, 45);		//money drop
            npc.npcSlots = 1f;
            npc.boss = true;  
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.buffImmune[24] = true;
            music = MusicID.TheTowers;			//boss music
            npc.netAlways = true;
            if (npc.life <= 350000) //Phase 2 name and display name also with damage and defense check if npc health is lesser or same the value
			{	
				npc.name = "SharkneonP2";		//boss name
				npc.displayName = "Injured King Sharkneon";		//display name
				npc.damage = 900;  //boss damage
				npc.defense = 0;    //boss defense
			}
			else //else if the value of 35000 is not reached the boss will get the values below
			{
				npc.name = "Sharkneon";		//boss name
				npc.displayName = "King Sharkneon";		//display name
				npc.damage = 300;  //boss damage
				npc.defense = 124;    //boss defense
			}
        }
		public override void HitEffect(int hitDirection, double damage)
		{	
            Main.PlaySound(41, (int)npc.position.X, (int)npc.position.Y, 0);
		}
		
		public override bool Autoload(ref string name, ref string texture, ref string[] altTextures)
		{
            if (npc.life <= 350000)
			{
				texture = "CraftMaxedHacks/NPCs/Boss/KingSharkneon";
			}
			else
			{
				texture = "CraftMaxedHacks/NPCs/Boss/KingSharkneonPhase2";
			}
			return mod.Properties.Autoload;
		}
        public override void AutoloadHead(ref string headTexture, ref string bossHeadTexture)
        {
            if (npc.life <= 350000)
			{
				bossHeadTexture = "CraftMaxedHacks/NPCs/Boss/KingSharkneon_Head_Boss"; //the boss head texture
			}
			else
			{
				bossHeadTexture = "CraftMaxedHacks/NPCs/Boss/KingSharkneonPhase2_Head_Boss";
			}
        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale);  //boss life scale in expertmode
            npc.damage = (int)(npc.damage * 0.6f);  //boss damage increase in expermode
        }

        public override void BossLoot(ref string name, ref int potionType)
        {
			name = "The King Sharkneon";
			if (Main.rand.Next(10) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("KingSharkneonTrophy"));
			}
			if (Main.expertMode)
			{
			}
			else
			{
				potionType = ItemID.SuperHealingPotion;   //boss drops
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ItemName"));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ItemName"));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ItemName"));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ItemName"));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ItemName"));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ItemName"));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ItemName"));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ItemName"));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ItemName"));
				if (Main.rand.Next(5) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GreatShark"));
				}
				else if (Main.rand.Next(5) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ExampleStaff"));
				}
			

				if (Main.rand.Next(3) == 0)   //item rarity
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ItemName")); //Item spawn
				}

				if (Main.rand.Next(3) == 0)   //item rarity
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ItemName")); //Item spawn
				}

				if (Main.rand.Next(3) == 0)   //item rarity
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ItemName")); //Item spawn
				}

				if (Main.rand.Next(3) == 0)   //item rarity
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ItemName")); //Item spawn
				}

				if (Main.rand.Next(3) == 0)   //item rarity
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ItemName")); //Item spawn
				}
			}
			CMHWorld.downedSharkneon = true;   //sets npc.downedBoss to true my downedSharkneon bool is located in $Source/CMHWorld.cs
        }		
		public override void AI()
		{
            npc.ai[0]++;
            Player P = Main.player[npc.target];
            if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
            {
                npc.TargetClosest(true);
            }
            npc.netUpdate = true;

            npc.ai[1]++;			//ai 1
            if (npc.ai[1] >= 100)  // 100 is projectile fire rate(125 on second time)
            {
				delay = 0; //enable delay
				delay++; //start of delay between 2 shots				
            }
			if (delay == 1)
			{
                float Speed = 3f;  //projectile speed
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = (npc.damage - 30) / 2;
				if (Main.expertMode)
				{
					damage = (int)(damage / Main.expertDamage);
				}  //projectile damage used with npc.damage- because just in case of phase 2
                int type = mod.ProjectileType("Bubble");  //put your projectile
                float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
				Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
				int numberProjectiles = 3; //3 or 4 or 5 shots
				for (int i = 0; i < numberProjectiles; i++)
				{
					Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
				}
			}
			if (delay == 11)
			{
                float Speed = 3f;  //projectile speed
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = (npc.damage - 30) / 2;
				if (Main.expertMode)
				{
					damage = (int)(damage / Main.expertDamage);
				}  //projectile damage used with npc.damage- because just in case of phase 2
                int type = mod.ProjectileType("Bubble");  //put your projectile
                float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
				Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
				int numberProjectiles = 3; //3 or 4 or 5 shots
				for (int i = 0; i < numberProjectiles; i++)
				{
					Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
				}
				npc.ai[1] -= 10; //decreases npc.ai[1] variable by 10 for time between shots
			}
			if (npc.ai[1] == 125) //You might be wondering how this works:simply it sets the value to 0 so the rate is now 125 instead of 100(25 between each shot and reset+100 between 0 and shots=125) by the way every thing starts of with 0 so it is 100 on first shot
			{
                npc.ai[1] = 0; //set the ai to 0
			}
			
			
			npc.ai[2]++; //npc.ai[2] will go higher 
            if (npc.ai[2] >= 2500)  //Npc spown rate
            {
                NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("NeonGuard"));  //NPC name
				npc.ai[2] = 0;
            }
            if (npc.life <= 35000)  //when the boss has less than 35000 health phase 2 will trigger
			{
                npc.ai[0]++;                //Re:Phase 1
                npc.ai[1]++;                //Projectile
				npc.ai[2]++;                //Npc
                npc.ai[3]++;                //Charge Attack
			}
            if (npc.ai[3] >= 20)
            {
                npc.velocity.X *= 0.98f;
                npc.velocity.Y *= 0.98f;
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width * 0.5f), npc.position.Y + (npc.height * 0.5f));
                {
                    float rotation = (float)Math.Atan2((vector8.Y) - (Main.player[npc.target].position.Y + (Main.player[npc.target].height * 0.5f)), (vector8.X) - (Main.player[npc.target].position.X + (Main.player[npc.target].width * 0.5f)));
                    npc.velocity.X = (float)(Math.Cos(rotation) * 12) * -1;
                    npc.velocity.Y = (float)(Math.Sin(rotation) * 12) * -1;
                }
                //Dust
                npc.ai[0] %= (float)Math.PI * 2f;
                Vector2 offset = new Vector2((float)Math.Cos(npc.ai[0]), (float)Math.Sin(npc.ai[0]));
                Main.PlaySound(15, (int)npc.position.X, (int)npc.position.Y, 20);
                npc.ai[3] = -300;
                Color color = new Color();
                Rectangle rectangle = new Rectangle((int)npc.position.X, (int)(npc.position.Y + ((npc.height - npc.width) / 2)), npc.width, npc.width);
                int count = 30;
                for (int i = 1; i <= count; i++)
                {
                    int dust = Dust.NewDust(npc.position, rectangle.Width, rectangle.Height, 6, 0, 0, 100, color, 2.5f);
                    Main.dust[dust].noGravity = false;
                }
				npc.ai[3] = 0;
                return;
            }
		}
    }
}
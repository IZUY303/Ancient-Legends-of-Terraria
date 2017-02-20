using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftMaxedHacks.Projectiles
{

    public class Bubble : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Neonic Bubble";  //projectile name
            projectile.width = 20;       //projectile width
            projectile.height = 28;  //projectile height
            projectile.friendly = false;      //make that the projectile will not damage you
            projectile.melee = true;         // effcted by melee boosters
            projectile.tileCollide = true;   //make that the projectile will be destroed if it hits the terrain
            projectile.penetrate = 5;      //how many npc will penetrate
            projectile.timeLeft = 2500;   //how many time this projectile has before disepire
            projectile.light = 0.75f;    // projectile light
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
			aiType = ProjectileID.DeathSickle;   
        }
    }
}
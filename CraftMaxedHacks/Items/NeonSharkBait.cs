using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftMaxedHacks.Items
{
    public class NeonSharkBait : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Neonic Fishbait";
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            AddTooltip("Strange fishbait,perharps use it at night");
            AddTooltip2("Summons Neon Invasion");
            item.value = 100;
            item.rare = 1;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }
        public override bool CanUseItem(Player player)
        {               
            return !NPC.AnyNPCs(mod.NPCType("KingSharkneon")) && !NPC.AnyNPCs(mod.NPCType("WormHead")) && !NPC.AnyNPCs(mod.NPCType("NeonGuard")) && Main.hardMode && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3;
        }
        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("KingSharkneon"));   //boss spawn{
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("NeonGuard"));   //boss spawn{
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("NeonGuard"));   //boss spawn
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("WormHead"));   //boss spawn
            Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);

            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SummonerItem"), 35);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

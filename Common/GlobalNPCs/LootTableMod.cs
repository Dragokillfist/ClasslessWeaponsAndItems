using ClasslessWeaponsAndItems.Core.ItemDropRules.DropConditions;
using ClasslessWeaponsAndItems.Content.Items;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClasslessWeaponsAndItems.Common.GlobalNPCs
{
    // This file shows numerous examples of what you can do with the extensive NPC Loot lootable system.
    // You can find more info on the wiki:
    public class LootTableMod : GlobalNPC
    {
        // ModifyNPCLoot uses a unique system called the ItemDropDatabase, which has many different rules for many different drop use cases.
        // Here we go through all of them, and how they can be used.
        // There are tons of other examples in vanilla! In a decompiled vanilla build, GameContent/ItemDropRules/ItemDropDatabase adds item drops to every single vanilla NPC, which can be a good resource.
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            // This is a simple example of how to add a drop to an NPC.
            // The first argument is the item ID, the second is the chance of it dropping (1 in 3), and the third is the amount of items dropped (1).
            // The last argument is a condition that must be met for the item to drop. In this case, it is a simple condition that always returns true.
            // You can find more conditions in the Conditions folder in this mod.
            // You can also create your own conditions by creating a new class that inherits from IItemDropRuleCondition.

            // Example: Add a drop to the Eye of Cthulhu
            if (npc.type == NPCID.KingSlime) {
            }
        }
    }
}
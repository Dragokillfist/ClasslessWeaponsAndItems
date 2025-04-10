using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClasslessWeapons.Content.Items.Classless
{
    public class IronRod : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 20;
            Item.DamageType = DamageClass.Default; // Use the Default damage class
            Item.width = 25;
            Item.height = 25;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 5;
            Item.value = Item.buyPrice(silver: 1);
            Item.rare = ItemRarityID.White; // Common rarity
            Item.UseSound = SoundID.Item1; // Default sound for melee weapons
            Item.autoReuse = false; // Allows auto-swinging
        }
        
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.IronBar, 10); // Requires 10 iron bars to craft
            recipe.AddTile(TileID.Anvils); // Requires an anvil to craft
            recipe.Register();
        }
    }
}
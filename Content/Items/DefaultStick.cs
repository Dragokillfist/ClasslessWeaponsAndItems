using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClasslessWeaponsAndItems.Content.Items
{ 
    public class DefaultStick : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 10;
            Item.DamageType = ModContent.GetInstance<Common.DamageClasses.GenericDamageClass>();
            Item.width = 20;
            Item.height = 20;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Thrust;
            Item.knockBack = 5;
            Item.value = Item.buyPrice(silver: 1);
            Item.rare = ItemRarityID.White; // Common rarity
            Item.UseSound = SoundID.Item1; // Default sound for melee weapons
            Item.autoReuse = false; // Allows auto-swinging
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 10); // Requires 10 wood to craft
            recipe.AddTile(TileID.WorkBenches); // Requires a workbench to craft
            recipe.Register();
        }
    }
}
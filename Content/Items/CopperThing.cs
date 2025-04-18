using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClasslessWeaponsAndItems.Content.Items
{ 
    public class CopperThing : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 13; //the damage the item will do
            Item.DamageType = DamageClass.Default; // this is the damage type it will deal
            Item.width = 20; // the width of the items hitbox
            Item.height = 20; // the height of the items hitbox
            Item.useTime = 15; // the time it takes to use the item
            Item.useAnimation = 15; // the time it takes for the item to finish the animation
            Item.useStyle = ItemUseStyleID.Swing; // the animation that this item will use
            Item.knockBack = 5; // the amount of knockback this item will do
            Item.value = Item.buyPrice(silver: 1); // Value of the item in silver coins
            Item.rare = ItemRarityID.White; // Common rarity
            Item.UseSound = SoundID.Item1; // Default sound for melee weapons
            Item.autoReuse = true; // Allows auto-swinging
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.CopperBar, 10); 
            recipe.AddTile(TileID.Anvils); 
            recipe.Register();
        }
    }
}
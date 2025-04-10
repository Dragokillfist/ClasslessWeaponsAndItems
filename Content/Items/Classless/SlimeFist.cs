using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClasslessWeapons.Content.Items.Classless
{
    public class SlimeFist : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 38; // Damage dealt by the item
            Item.DamageType = DamageClass.Generic; // Damage type of the item
            Item.width = 20; // Width of the item in pixels
            Item.height = 20; // Height of the item in pixels
            Item.useTime = 15; // Time taken to use the item (in frames)
            Item.useAnimation = 15; // Animation time for using the item (in frames)
            Item.useStyle = ItemUseStyleID.Swing; // Style of using the item (swinging)
            Item.knockBack = 5; // Knockback value of the item
            Item.value = Item.buyPrice(silver: 1); // Value of the item in coins
            Item.rare = ItemRarityID.Expert; // Rarity of the item (common)
            Item.UseSound = SoundID.Item1; // Sound played when using the item
            Item.autoReuse = false; // Whether the item can be auto-swung or not
        }
    }
}
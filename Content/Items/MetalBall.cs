using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClasslessWeaponsAndItems.Content.Items
{ 
    public class MetalBall : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 15;
            Item.DamageType = ModContent.GetInstance<Common.DamageClasses.GenericDamageClass>();
            Item.width = 20;
            Item.height = 20;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 5;
            Item.value = Item.buyPrice(silver: 1);
            Item.rare = ItemRarityID.White; // Common rarity
            Item.UseSound = SoundID.Item1; // Default sound for melee weapons
            Item.autoReuse = false; // Allows auto-swinging
        }
    }
}
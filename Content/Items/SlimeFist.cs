using ClasslessWeaponsAndItems.Content.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClasslessWeaponsAndItems.Content.Items
{ 
    public class SlimeFist : ModItem
    {
        public int attackType = 0; // keeps track of which attack it is
        public int comboExpireTimer = 0; // we want the attack pattern to reset if the weapon is not used for certain period of time
        public override void SetDefaults()
        {
            Item.width = 20; // Width of the item in pixels
            Item.height = 20; // Height of the item in pixels
            Item.value = Item.buyPrice(silver: 1); // Value of the item in coins
            Item.rare = ItemRarityID.Expert; // Rarity of the item (common)
            Item.useTime = 15; // Time taken to use the item (in frames)
            Item.useAnimation = 15; // Animation time for using the item (in frames)
            Item.useStyle = ItemUseStyleID.Rapier; // Style of using the item
            Item.knockBack = 5; // Knockback value of the item
            Item.UseSound = SoundID.Item1; // Sound played when using the item
            Item.autoReuse = true; // Whether the item can be auto-swung or not
            Item.damage = 38; // Damage dealt by the item
            Item.DamageType = DamageClass.Generic; // Damage type of the item
            Item.shoot = ModContent.ProjectileType<SlimeBall>(); // The projectile type that the item shoots
        }

		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) {
			// Using the shoot function, we override the swing projectile to set ai[0] (which attack it is)
			Projectile.NewProjectile(source, position, velocity, type, damage, knockback, Main.myPlayer, attackType);
			attackType = (attackType + 1) % 2; // Increment attackType to make sure next swing is different
			comboExpireTimer = 0; // Every time the weapon is used, we reset this so the combo does not expire
			return false; // return false to prevent original projectile from being shot
		}

		public override void UpdateInventory(Player player) {
			if (comboExpireTimer++ >= 15) // after 120 ticks (== 2 seconds) in inventory, reset the attack pattern
				attackType = 0;
		}

		public override bool MeleePrefix() {
			return true; // return true to allow weapon to have melee prefixes (e.g. Legendary)
		}
    }
}
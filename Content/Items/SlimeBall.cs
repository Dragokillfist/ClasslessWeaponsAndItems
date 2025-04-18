using ClasslessWeaponsAndItems.Content.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClasslessWeaponsAndItems.Content.Items
{
	// SlimeBall is a projectile that is used by the SlimeFist item.
	// It is a simple projectile that moves in a straight line and deals damage to enemies.
	public class SlimeBall : ModItem
	{
		public override void SetDefaults() {
			Item.width = 20; // Width of the projectile hitbox
			Item.height = 20; // Height of the projectile hitbox
			Item.damage = 38; // Damage dealt by the projectile
			Item.DamageType = DamageClass.Generic; // Damage type of the projectile
			Item.maxStack = Item.CommonMaxStack; // Maximum stack size of the projectile
			Item.consumable = true; // Whether the projectile is consumable or not
			Item.knockBack = 5; // Knockback value of the projectile
			Item.value = Item.buyPrice(silver: 1); // Value of the projectile in coins
			Item.shoot = ModContent.ProjectileType<SlimeBallProjectile>(); // The projectile that is spawned when using this item
			Item.shootSpeed = 10f; // Speed of the projectile
			Item.ammo = Item.type; // The ammo class this projectile belongs to
		}
	}
}
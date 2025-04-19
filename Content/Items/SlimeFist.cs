using ClasslessWeaponsAndItems.Content.Projectiles;
using ClasslessWeaponsAndItems.Common.DamageClasses;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClasslessWeaponsAndItems.Content.Items
{ 
    public class SlimeFist : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20; // Width of the item in pixels
            Item.height = 20; // Height of the item in pixels
            Item.value = Item.buyPrice(silver: 1); // Value of the item in coins
            Item.rare = ItemRarityID.Expert; // Rarity of the item (common)
            Item.useTime = 15; // Time taken to use the item (in frames)
            Item.useAnimation = 15; // Animation time for using the item (in frames)
            Item.useStyle = ItemUseStyleID.Thrust; // Style of using the item
            Item.knockBack = 5; // Knockback value of the item
            Item.UseSound = SoundID.Item1; // Sound played when using the item
            Item.autoReuse = true; // Whether the item can be auto-swung or not
            Item.damage = 38; // Damage dealt by the item
            Item.DamageType = ModContent.GetInstance<Common.DamageClasses.GenericDamageClass>(); // Damage type of the item
            Item.shoot = ModContent.ProjectileType<Projectiles.SlimeBallProjectile>(); // Projectile type spawned when using the item
            Item.shootSpeed = 10f; // Speed of the projectile spawned
			//Item.useAmmo = ModContent.ItemType<SlimeBall>(); // Ammo type used by the item
        }
/*
		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) {
			Vector2 target = Main.screenPosition + new Vector2(Main.mouseX, Main.mouseY);
			float ceilingLimit = target.Y;
			if (ceilingLimit > player.Center.Y - 200f) {
				ceilingLimit = player.Center.Y - 200f;
			}
			// Loop these functions 3 times.
			for (int i = 0; i < 3; i++) {
				position = player.Center - new Vector2(Main.rand.NextFloat(401) * player.direction, 600f);
				position.Y -= 100 * i;
				Vector2 heading = target - position;

				if (heading.Y < 0f) {
					heading.Y *= -1f;
				}

				if (heading.Y < 20f) {
					heading.Y = 20f;
				}

				heading.Normalize();
				heading *= velocity.Length();
				heading.Y += Main.rand.Next(-40, 41) * 0.02f;
				Projectile.NewProjectile(source, position, heading, type, damage * 2, knockback, player.whoAmI, 0f, ceilingLimit);
			}

			return false;
		}
		*/
    }
}
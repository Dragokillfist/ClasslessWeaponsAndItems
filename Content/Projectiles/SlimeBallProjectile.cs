using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClasslessWeaponsAndItems.Content.Projectiles
{
	// ExampleCustomSwingSword is an example of a sword with a custom swing using a held projectile
	// This is great if you want to make melee weapons with complex swing behavior
	// Note that this projectile only covers 2 relatively simple swings, everything else is up to you
	// Aside from the custom animation, the custom collision code in Colliding is very important to this weapon
	public class SlimeBallProjectile : ModProjectile
	{
        public override void SetDefaults()
        {
            Projectile.arrow = false;
			Projectile.width = 20; // Width of the projectile hitbox
			Projectile.height = 20; // Height of the projectile hitbox
			Projectile.friendly = true; // Can hit enemies
			//Projectile.aiStyle = 24;
			Projectile.DamageType = DamageClass.Generic; // Damage type of the projectile
			AIType = ProjectileID.SpikyBall;
			Projectile.timeLeft = 600; // Time before the projectile despawns
        }

		public override void AI() {
			// The code below was adapted from the ProjAIStyleID.Arrow behavior. Rather than copy an existing aiStyle using Projectile.aiStyle and AIType,
			// like some examples do, this example has custom AI code that is better suited for modifying directly.
			// See https://github.com/tModLoader/tModLoader/wiki/Basic-Projectile#what-is-ai for more information on custom projectile AI.

			// Apply gravity after a quarter of a second
			Projectile.ai[0] += 1f;
			if (Projectile.ai[0] >= 15f) {
				Projectile.ai[0] = 15f;
				Projectile.velocity.Y += 0.1f;
			}

			// The projectile is rotated to face the direction of travel
			Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2;

			// Cap downward velocity
			if (Projectile.velocity.Y > 160f) {
				Projectile.velocity.Y = 160;
			}
		}
		public override bool OnTileCollide(Vector2 oldVelocity) {
			// The projectile will bounce off tiles, but not if it is moving too slowly
			if (Projectile.velocity.X > 1f || Projectile.velocity.X < -1f || Projectile.velocity.Y > 1f || Projectile.velocity.Y < -1f) {
				Projectile.velocity.X = oldVelocity.X * 0.5f;
				Projectile.velocity.Y = oldVelocity.Y * -0.5f;
			}
			return false; // Return false to prevent the default tile collision behavior
		}

		/*public override void OnKill(int timeLeft) {
			SoundEngine.PlaySound(SoundID.Dig, Projectile.position); // Plays the basic sound most projectiles make when hitting blocks.
			for (int i = 0; i > 500; i++) // Creates a splash of dust around the position the projectile dies.
			{
				Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, DustID.Silver);
				dust.noGravity = true;
				dust.velocity *= 1.5f;
				dust.scale *= 0.9f;
			} 
		}*/
	}
}
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TutorialMod.Projectiles
{
	public class KatanaProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 3600;
			projectile.tileCollide = true;
		}
		public override void AI()
        {
			float ProjectileVelRotation = projectile.velocity.ToRotation();
			projectile.rotation = ProjectileVelRotation + MathHelper.ToRadians(90f);
		}
	}
}
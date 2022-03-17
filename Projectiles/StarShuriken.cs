using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TutorialMod.Projectiles
{
    public class StarShuriken : ModProjectile
    {
		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.penetrate = 7;
			projectile.timeLeft = 3600;
			projectile.tileCollide = true;
		}
	}
}

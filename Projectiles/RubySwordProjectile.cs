using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TutorialMod.Projectiles
{
	public class RubySwordProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.melee = true;
			projectile.damage = 18;
			projectile.CloneDefaults(ProjectileID.RubyBolt);
			aiType = ProjectileID.RubyBolt;
		}

		public override bool PreKill(int timeLeft)
		{
			projectile.type = ProjectileID.RubyBolt;
			return true;
		}
	}
}

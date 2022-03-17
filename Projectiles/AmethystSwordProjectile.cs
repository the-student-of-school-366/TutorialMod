﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TutorialMod.Projectiles
{
	public class AmethystSwordProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.melee = true;
			projectile.damage = 10;
			projectile.CloneDefaults(ProjectileID.AmethystBolt);
			aiType = ProjectileID.AmethystBolt;
		}

		public override bool PreKill(int timeLeft)
		{
			projectile.type = ProjectileID.AmethystBolt;
			return true;
		}
	}
}

using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TutorialMod.Dusts;
using TutorialMod.Items;

namespace TutorialMod.Projectiles
{
	public class SparklingBall : ModProjectile
	{
		public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Bolt of light");
        }
		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 600;
			projectile.tileCollide = true;
		}

		public override void AI()
		{
			/*projectile.velocity.Y += projectile.ai[0];
			if (Main.rand.NextBool(3))
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, ModContent.DustType<Sparkle>(), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}*/
			//projectile.velocity.Y = 0;
			projectile.ai[0] += 1;
			if (projectile.ai[0] == 60)
            {
				Projectile.NewProjectile(projectile.position,-(projectile.velocity),ProjectileID.UnholyTridentFriendly, (int)(projectile.damage * 2f), 0, projectile.owner);
				projectile.ai[0] = 0;
            }
			projectile.velocity.Y = 0;

			if (projectile.velocity.X < 1 && projectile.velocity.X > -1)
				if (Main.rand.Next(2) == 0)
					projectile.velocity.X = 6;
				else
					projectile.velocity.X = -6;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			/*{ projectile.penetrate--;
			if (projectile.penetrate <= 0)
			{
				projectile.Kill();
			}
			else
			{
				projectile.ai[0] += 0.1f;
				if (projectile.velocity.X != oldVelocity.X)
				{
					projectile.velocity.X = -oldVelocity.X;
				}
				if (projectile.velocity.Y != oldVelocity.Y)
				{
					projectile.velocity.Y = -oldVelocity.Y;
				}
				projectile.velocity *= 0.75f;
				Main.PlaySound(SoundID.Item10, projectile.position);
			}*/
			Projectile.NewProjectile(projectile.position,projectile.velocity,ProjectileID.DeathSickle, (int)(projectile.damage * 2f), projectile.knockBack, projectile.owner);
			projectile.Kill();
			return false;
		}

		public override void Kill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, ModContent.DustType<Sparkle>(), projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
			}
			Main.PlaySound(SoundID.Item25, projectile.position);
		}

	}
}
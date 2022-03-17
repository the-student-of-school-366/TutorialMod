using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using TutorialMod.Items;


namespace TutorialMod.Projectiles
{
    class BulletGunProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gun");
        }
		public override void SetDefaults()
		{
			projectile.width = 42;
			projectile.height = 30;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 600;
		}
		public override void AI()
        {
			 float velRotation = projectile.rotation + projectile.velocity.ToRotation();
			int InternalRotation = Main.rand.Next(15);
			projectile.rotation = velRotation + MathHelper.ToRadians(InternalRotation);
			projectile.rotation += (float) projectile.direction * 0.95f;
			 projectile.ai[1] += 1;
			if (projectile.ai[1] == 22)
            {
				Main.PlaySound(SoundID.Item100, projectile.Center);
				Projectile.NewProjectile(projectile.position, new Vector2(projectile.velocity.X + projectile.direction * velRotation + MathHelper.ToRadians(InternalRotation), projectile.velocity.Y + projectile.direction * velRotation +  + MathHelper.ToRadians(InternalRotation)), ProjectileID.Bullet, projectile.damage/2, projectile.knockBack, projectile.owner);
				projectile.ai[1] = 0;
            }
		}
	}
}

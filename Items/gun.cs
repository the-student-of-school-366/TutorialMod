using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TutorialMod.Projectiles;

namespace TutorialMod.Items
{
    public class gun : ModItem
    {
        public override void SetDefaults()
        {
            item.ranged = true;
            item.damage = 22;
            item.width = 80;
            item.height = 60;
            item.useAnimation = 40;
            item.useTime = 40;
            item.useStyle = 5;
            item.value = 50000000;
            item.rare = ItemRarityID.Gray;
            item.UseSound = SoundID.Item115;
            item.noMelee = true;
            item.autoReuse = true;
            item.shoot = ModContent.ProjectileType<StarShuriken>();
            item.shootSpeed = 10f;
            item.useAmmo = AmmoID.Bullet;
        }
    }
}

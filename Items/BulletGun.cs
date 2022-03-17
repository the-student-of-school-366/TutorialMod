using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TutorialMod.Projectiles;

namespace TutorialMod.Items
{
    public class BulletGun : ModItem
    {
        public override void SetDefaults()
        {
            item.ranged = true;
            item.damage = 14;
            item.width = 36;
            item.height = 16;
            item.useAnimation = 20;
            item.useTime = 20;
            item.useStyle = 5;
            item.value = Item.sellPrice(gold: 1);
            item.rare = ItemRarityID.Orange;
            item.UseSound = SoundID.Item100;
            item.noMelee = true;
            item.autoReuse = true;
            item.shoot = ModContent.ProjectileType<BulletGunProjectile>();
            item.shootSpeed = 10f;
            item.useAmmo = AmmoID.Bullet;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = ModContent.ProjectileType<BulletGunProjectile>();
            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Handgun, 1);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

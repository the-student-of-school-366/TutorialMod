using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TutorialMod.Projectiles;


namespace TutorialMod.Items
{
    public class Katana : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Katana");
        }
        public override void SetDefaults()
        {
            item.melee = true;
            item.damage = 25;
            item.width = 42;
            item.height = 46;
            item.useAnimation = 20;
            item.useTime = 20;
            item.useStyle = 1;
            item.crit = 46;
            item.shoot = ModContent.ProjectileType<KatanaProjectile>();
            item.shootSpeed = 6;
            item.value = 10000;
            item.rare = ItemRarityID.Blue;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldBar, 8);
            recipe.AddIngredient(ItemID.SilverBar, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.Stinky,600000);
            player.AddBuff(BuffID.WaterWalking, 6000);
            if (crit == true)
            {
                player.AddBuff(BuffID.DeadlySphere, 600);
            }
        }

    }
}

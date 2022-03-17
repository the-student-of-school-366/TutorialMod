using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TutorialMod.Items
{
    public class pew : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pixel");
            Tooltip.SetDefault("This is Sparta!!!");
        }
        public override void SetDefaults()
        {
            item.damage = 50;
            item.melee = true;
            item.width = 48;
            item.height = 48;
            item.useAnimation = 10;
            item.useTime = 10;
            item.useStyle = 1;
            item.rare = ItemRarityID.Expert;
            item.value = 10000;
            item.UseSound = SoundID.Item115;
            item.autoReuse = true;
            item.useTurn = true;
            item.shoot = ProjectileID.LaserMachinegunLaser;
            item.shootSpeed = 100f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LastPrism, 7);
            recipe.AddIngredient(ItemID.LavafallBlock, 30);
            recipe.AddTile(TileID.Trees);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

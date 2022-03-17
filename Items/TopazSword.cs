﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TutorialMod.Projectiles;
namespace TutorialMod.Items
{
    public class TopazSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Topaz Sword");
        }
        public override void SetDefaults()
        {
            item.melee = true;
            item.damage = 12;
            item.width = 42;
            item.height = 46;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 1;
            item.shoot = ModContent.ProjectileType<TopazSwordProjectile>();
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
            recipe.AddIngredient(ItemID.Topaz, 8);
            recipe.AddIngredient(ItemID.TinBar, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
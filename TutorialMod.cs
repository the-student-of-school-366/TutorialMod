using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace TutorialMod
{
	public class TutorialMod : Mod
	{
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LunarBar, 999);
            recipe.AddRecipeGroup(RecipeGroupID.Wood, 1);
            recipe.AddTile(TileID.Dirt);
            recipe.SetResult(ItemID.DirtBlock, 5);
            recipe.AddRecipe();
        }
    }
}
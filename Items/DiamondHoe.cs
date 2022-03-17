using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TutorialMod.Projectiles;


namespace TutorialMod.Items
{
    public class DiamondHoe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("DiamondHoe");
        }
        public override void SetDefaults()
        {
            item.melee = true;
            item.damage = 30;
            item.width = 54;
            item.height = 52;
        }
    }
       

}
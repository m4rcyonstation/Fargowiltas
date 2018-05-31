using Terraria.ModLoader;

namespace Fargowiltas.Items.Summons.SwarmSummons.Energizers
{
    public class EnergizerEye : ModItem
    {
        //until it has a use
        public override bool Autoload(ref string name)
        {
            return false;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Optical Energizer");
            Tooltip.SetDefault("'It feels like it's watching you'");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.rare = 1;
        }

        public override string Texture => "Fargowiltas/Items/Placeholder";
    }
}
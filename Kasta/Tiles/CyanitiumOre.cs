using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Kasta.Tiles
{
    public class CyanitiumOre : ModTile
    {
        public override void SetDefaults()
        {
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileValue[Type] = 350;
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 500;
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Cyanitium Ore");
            AddMapEntry(new Color(200, 20, 20), name);

            minPick = 70;
            dustType = DustID.Platinum;
            drop = ModContent.ItemType<Items.Placeables.CyanitiumOre>();
            soundType = SoundID.Tink;
            soundStyle = 1;
            mineResist = 2.5f;
        }
    }
}

using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.ID;

namespace Kasta.Tiles
{
    public class CyanitiumBar : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileShine[Type] = 1100;
            Main.tileSolid[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlockLight[Type] = false;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);


            AddMapEntry(new Color(255, 20, 20), Language.GetText("MapObject.MetalBar"));
            dustType = DustID.Platinum;
        }

        public override bool Drop(int i, int j)
        {
            Tile t = Main.tile[i, j];

            int style = t.frameX / 18;
            if (style == 0) 
            {
                Item.NewItem(i * 16, j * 16, 16, 16, ModContent.ItemType<Items.Placeables.CyanitiumBar>());
            }

            return base.Drop(i, j);
        }
    }
}

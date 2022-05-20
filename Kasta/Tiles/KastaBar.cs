using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace Kasta.Tiles
{
    public class KastaBar : ModTile
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


            AddMapEntry(new Color(104, 93, 195), Language.GetText("MapObject.MetalBar"));
            dustType = DustID.Silk;
        }

        public override bool Drop(int i, int j)
        {
            Tile t = Main.tile[i, j];
            int style = t.frameX / 18;
            int type = ItemType<Items.Placeables.KastaBar>();
            switch (style)
            {
                case 1:
                    type = ItemType<Items.Placeables.KastaBar>();
                    break;
                default:
                    break;
            }
            Item.NewItem(i * 16, j * 16, 16, 16, type);
            return base.Drop(i, j);
        }
    }
}
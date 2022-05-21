using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Kasta.Tiles
{
    public class SuspiciousPetrifiedEgg : ModTile
    {
        public override void SetDefaults()
        {
			Main.tileFrameImportant[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
			TileObjectData.newTile.Height = 3;
			TileObjectData.newTile.Origin = new Point16(1, 2);
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 18 };
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Suspicious Petrified Egg");
			AddMapEntry(new Color(255, 155, 0), name);
			dustType = DustID.Platinum;
			disableSmartCursor = true;
		}

        public override bool Drop(int i, int j)
        {
			Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("SuspiciousHead"), Main.rand.Next(1, 1));
            return base.Drop(i, j);
        }
    }
}

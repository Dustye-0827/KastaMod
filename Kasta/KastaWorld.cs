using Kasta.Tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;

namespace Kasta
{
    public class KastaWorld : ModWorld
    {
        #region Modify World Generation Tasks
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));

            #region Shinies
            if (ShiniesIndex != -1)
            {
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Kasta Shinies", GenerateShinies));
            }
            #endregion

            #region Ores
            if (ShiniesIndex != -1)
            {
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Kasta Ores", GenerateOres));
            }
            #endregion
        }
        #endregion

        #region Shinies
        private void GenerateShinies(GenerationProgress progress)
        {
            progress.Message = "Generating Kasta Shinies";

            #region Suspicious Petrified Egg
            for (int a = 0; a < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-05); a++)
            {
                bool placeSuccessful = false;

                Tile tile;
                int tileToPlace = ModContent.TileType<SuspiciousPetrifiedEgg>();

                while (!placeSuccessful)
                {
                    int x = WorldGen.genRand.Next(
                        0,
                        Main.maxTilesX
                    );

                    int y = WorldGen.genRand.Next(
                        0,
                        Main.maxTilesY
                    );

                    tile = Main.tile[
                         x,
                         y
                    ];

                    if (tile.type == TileID.Sand)
                    {
                        WorldGen.PlaceTile(x, y, tileToPlace);
                    }

                    placeSuccessful = tile.active() && tile.type == tileToPlace;
                }
            }
            #endregion
        }
        #endregion

        #region Ores
        private void GenerateOres(GenerationProgress progress)
        {
            progress.Message = "Generating Kasta Ores";

            #region Cyanitium Ore
            for (int a = 0; a < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-05); a++)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceHigh, Main.maxTilesY);

                Tile tile = Framing.GetTileSafely(x, y);
                if (tile.active() && tile.type == TileID.IceBlock) // Check if the specific X, Y Coordinates Tile is Ice
                {
                    WorldGen.TileRunner(
                    x, // x Coordinate
                    y, // y Coordinate
                    WorldGen.genRand.Next(25, 32), // Strength
                    WorldGen.genRand.Next(9, 17), // Steps
                    ModContent.TileType<CyanitiumOre>() // Tile
                    );
                }
            }
            #endregion
        }
        #endregion
    }
}

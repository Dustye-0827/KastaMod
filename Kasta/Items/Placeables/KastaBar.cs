using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Kasta.Items.Placeables
{
    public class KastaBar : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(16);
            item.rare = 1;
            item.value = Item.sellPrice(silver: 3);

            item.autoReuse = true;
            item.useTurn = true;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = ItemUseStyleID.SwingThrow;

            item.consumable = true;
            item.maxStack = 999;

            item.createTile = TileType<Tiles.KastaBar>();
            item.placeStyle = 0;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldBar, 1);
            recipe.AddIngredient(ItemID.DemoniteBar, 1);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.PlatinumBar, 1);
            recipe2.AddIngredient(ItemID.DemoniteBar, 1);
            recipe2.AddTile(TileID.Furnaces);
            recipe2.SetResult(this, 1);
            recipe2.AddRecipe();

            ModRecipe recipe3 = new ModRecipe(mod);
            recipe3.AddIngredient(ItemID.GoldBar, 1);
            recipe3.AddIngredient(ItemID.CrimtaneBar, 1);
            recipe3.AddTile(TileID.Furnaces);
            recipe3.SetResult(this, 1);
            recipe3.AddRecipe();

            ModRecipe recipe4 = new ModRecipe(mod);
            recipe4.AddIngredient(ItemID.PlatinumBar, 1);
            recipe4.AddIngredient(ItemID.CrimtaneBar, 1);
            recipe4.AddTile(TileID.Furnaces);
            recipe4.SetResult(this, 1);
            recipe4.AddRecipe();
        }
    }
}
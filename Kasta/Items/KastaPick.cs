using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Kasta.Items
{
    public class KastaPick : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kasta Pickaxe");
            Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item1;
            item.melee = true;
            item.damage = 9;
            item.width = 28;
            item.height = 24;
            item.useStyle = 1;
            item.useAnimation = 16;
            item.useTime = 16;
            item.autoReuse = true;
            item.knockBack = 3;
            item.pick = 60;
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(gold: 1); // Sets the item sell price to one gold coin.
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Wood", 10);
            recipe.AddIngredient(mod, "KastaBar", 13);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

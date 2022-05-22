using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Kasta.Items
{
    public class KastaGreatsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kasta Greatsword");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.damage = 36;
            item.melee = true;
            item.width = 64;
            item.height = 64;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 7.5f;
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(gold: 1);
            item.scale = 1.25f;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Wood", 10);
            recipe.AddIngredient(ItemID.WormTooth, 2);
            recipe.AddIngredient(mod, "KastaBar", 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

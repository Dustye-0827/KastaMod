using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Kasta.Items
{
    public class KastaHamaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kasta Hamaxe");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item1;
            item.melee = true;
            item.damage = 22;
            item.width = 44;
            item.height = 46;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useAnimation = 27;
            item.useTime = 27;
            item.autoReuse = true;
            item.knockBack = 7;
            item.hammer = 60;
            item.axe = 20;
            item.scale = 1.25f;
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(gold: 1);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Wood", 10);
            recipe.AddIngredient(mod, "KastaBar", 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

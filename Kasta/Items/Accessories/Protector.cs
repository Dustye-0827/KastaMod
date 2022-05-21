using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Kasta.Items.Accessories
{
    [AutoloadEquip(EquipType.Shield)]
    public class Protector : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kasta's Protector");
            Tooltip.SetDefault("Defense 6 \nGrants immunity to knockback \nGrants immunity to fireblocks \nIncrease life regen \n5% increase damage");
        }
        public override void SetDefaults()
        {

            item.width = 28;
            item.height = 24;
            item.accessory = true; // Makes this item an accessory. change this comment sometimes.
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(gold: 1); // Sets the item sell price to one gold coin.
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statDefense += 5;
            player.lifeRegen += 2;
            player.allDamageMult *= 1.05f;
            player.fireWalk = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BandofRegeneration);
            recipe.AddIngredient(mod, "KastaBar", 12);
            recipe.AddIngredient(ItemID.ObsidianShield);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

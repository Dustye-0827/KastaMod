using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Kasta.Items
{
    public class SuspiciousHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sandy Fang");
            Tooltip.SetDefault("`You hear underground noises...`" +
                "\nSummons the Cave Demolisher when used in the Desert");
            ItemID.Sets.SortingPriorityBossSpawns[item.type] = 12;
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 20;
            item.value = 100;
            item.rare = ItemRarityID.Blue;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            return Main.dayTime && player.ZoneDesert || player.ZoneUndergroundDesert;
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("CaveDemolisherHead"));
            Main.PlaySound(SoundID.ForceRoar, player.position, 0);
            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.WormScale>(), 15);
            recipe.AddIngredient(ItemID.SandBlock, 10);
            recipe.AddIngredient(ItemID.AntlionMandible, 3);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

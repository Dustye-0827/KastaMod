using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Kasta.Items
{
    public class CactusSpear : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cactus Spear");
            Tooltip.SetDefault("");
        }

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Spear);
			item.damage = 16;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 27;
			item.useAnimation = 27;
			item.knockBack = 7;
			item.value = 500;
			item.rare = ItemRarityID.Blue;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("CactusSpearProjectile");
		}

		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[mod.ProjectileType("CactusSpearProjectile")] < 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Cactus, 12);
			recipe.AddIngredient(ItemID.Spear, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
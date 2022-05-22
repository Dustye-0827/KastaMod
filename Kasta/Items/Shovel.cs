using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Kasta.Items
{
	public class Shovel : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Bloody Shovel");
		}

		public override void SetDefaults() 
		{
			item.damage = 14;
			item.melee = true;
			item.width = 49;
			item.height = 49;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 0, 75, 60);
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.pick = 55;
			item.scale = 1.3f;
		}
	}
}
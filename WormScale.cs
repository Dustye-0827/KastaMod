using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Kasta.Items
{
	public class WormScale : ModItem
	{
		public override void SetStaticDefaults() 
		{
		}

		public override void SetDefaults() 
		{
			item.width = 22;
			item.height = 22;
			item.value = Item.buyPrice(0, 0, 5, 10);
			item.rare = ItemRarityID.Blue;
			item.maxStack = 999;
		}
	}
}
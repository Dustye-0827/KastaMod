using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace Kasta
{
	public class Kasta : Mod
	{
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Bar", new int[]
			{
		ItemID.DemoniteBar,
		ItemID.CrimtaneBar
			});
			RecipeGroup.RegisterGroup("Evil Bar", group);

			RecipeGroup group2 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Gold Bar", new int[]
			{
		ItemID.GoldBar,
		ItemID.PlatinumBar
	        });
			RecipeGroup.RegisterGroup("Gold Bar", group2);
		}
	}
}
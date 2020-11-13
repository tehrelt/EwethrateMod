using Terraria.ID;
using Terraria.ModLoader;

namespace EwethrateMod.Items.Materials.Metal
{
	public class EwethrateBar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("EwethrateSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults() 
		{
			item.width = 30;
			item.height = 24;
			item.value = 10000;
			item.maxStack = 999;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.material = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
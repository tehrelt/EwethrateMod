using Terraria.ID;
using Terraria.ModLoader;

namespace EwethrateMod.Items.Equipment.Weapons
{
	public class EwethrateSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("EwethrateSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults() 
		{
			item.damage = 50;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.GetInstance<Materials.Metal.EwethrateBar>(), 10);
			recipe.AddTile(ItemID.IronAnvil);
			recipe.AddTile(ItemID.LeadAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
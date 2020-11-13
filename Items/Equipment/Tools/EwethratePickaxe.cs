using Terraria.ID;
using Terraria.ModLoader;

namespace EwethrateMod.Items.Equipment.Tools
{
    class EwethratePickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Ewethrate PickAxe");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
			item.damage = 40;
			item.melee = true;
			item.width = 42;
			item.height = 40;
			item.useTime = 5;
			item.useAnimation = 15;
			item.pick = 215;
			item.axe = 26;
			item.tileBoost++;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 
			item.rare = 5;
			item.UseSound = SoundID.Item71;
			item.autoReuse = true;
		}

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.GetInstance<Materials.Metal.EwethrateBar>(), 15);
			recipe.AddTile(ItemID.IronAnvil);
			recipe.AddTile(ItemID.LeadAnvil);
			recipe.AddRecipe();

        }
    }
}

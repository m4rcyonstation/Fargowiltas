using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Fargowiltas.Items.Enchantments
{
	public class ForbiddenEnchant : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Forbidden Enchantment");
			Tooltip.SetDefault("'Walk like an Egyptian' \n10% increased magic and minion damage \nIncreases your max number of minions by 2 \nDouble tap down to call an ancient storm to the cursor location");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.accessory = true;
			ItemID.Sets.ItemNoGravity[item.type] = true;
			item.rare = 5; 
			item.value = 80000; 
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
        {
			FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>(mod);
			
			player.maxMinions += 2;
			player.minionDamage += 0.1f;
			player.magicDamage += 0.1f;
			if(soulcheck.forbidden == true)
			{
			player.setForbidden = true;
			player.UpdateForbiddenSetLock();
			Lighting.AddLight(player.Center, 0.8f, 0.7f, 0.2f);
			}
			
        }
		
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AncientBattleArmorHat);
            recipe.AddIngredient(ItemID.AncientBattleArmorShirt);
			recipe.AddIngredient(ItemID.AncientBattleArmorPants);
			recipe.AddIngredient(ItemID.SpiritFlame);
			recipe.AddIngredient(ItemID.ShadowFlameHexDoll);
			recipe.AddIngredient(ItemID.DeadlySphereStaff);
			recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}
		
	





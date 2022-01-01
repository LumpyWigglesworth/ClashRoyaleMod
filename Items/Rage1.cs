using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClashRoyaleMod.Items
{
    class Rage1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rage Spell");
            Tooltip.SetDefault("Increases attack and speed of an area by 35%.");
        }

        public override void SetDefaults()
        {
            item.magic = true;
            item.width = 11;
            item.height = 15;
            item.mana = 80;
            item.noMelee = true;
            item.damage = 0;
            item.UseSound = SoundID.Item7;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 60;
            item.useAnimation = 60;
            item.value = Item.buyPrice(gold: 2, silver: 50);
            item.rare = ItemRarityID.Lime;
            item.shootSpeed = 9f;
            
        }
    }
}

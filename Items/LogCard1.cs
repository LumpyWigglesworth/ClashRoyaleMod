using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using ClashRoyaleMod.Projectiles;

namespace ClashRoyaleMod.Items
{
    class LogCard1 : ModItem
    {
        public override string Texture => "ClashRoyaleMod/Items/LogCard";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Log (LVL 1)");
            Tooltip.SetDefault("A normal log gone berserk due to a rage spill.");
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.width = 16;
            item.height = 20;
            item.magic = true;
            item.noMelee = true;
            item.mana = 40;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.useTime = 60;
            item.useAnimation = 60;
            item.value = Item.buyPrice(gold: 10);
            item.rare = ItemRarityID.Cyan;
            item.shoot = ModContent.ProjectileType<TheLog>();
            item.shootSpeed = 10;
            item.UseSound = SoundID.Item19;
            item.knockBack = 8;
        }
    }
}

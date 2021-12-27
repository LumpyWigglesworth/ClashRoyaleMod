using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ClashRoyaleMod.Items
{
    class KingsCannon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("King's Cannon");
            Tooltip.SetDefault("The King's trusty cannon.");
        }
        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 30;
            item.ranged = true;
            item.noMelee = true;
            item.damage = 80;
            item.value = Item.sellPrice(gold: 5);
            item.channel = true;
            item.useTime = 120;
            item.useAnimation = 120;
            item.shootSpeed = 10f;
            item.UseSound = SoundID.Item14;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.shoot = ProjectileID.CannonballFriendly;
        }
    }
}

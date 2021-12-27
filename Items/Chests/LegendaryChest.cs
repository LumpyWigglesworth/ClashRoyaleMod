using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Utilities;

namespace ClashRoyaleMod.Items.Chests
{
    class LegendaryChest : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Legendary Chest");
            Tooltip.SetDefault("<right> to draw a random Legendary card.");
        }
        public override void SetDefaults()
        {
            item.width = 60;
            item.height = 52;
            item.rare = ItemRarityID.Cyan;
            item.value = Item.buyPrice(gold: 10);
        }
        public override void RightClick(Player player)
        {
            var weightRand = new WeightedRandom<int>();
            weightRand.Add(ModContent.ItemType<LogCard1>());
            player.QuickSpawnItem(weightRand);
        }
        public override bool CanRightClick()
        {
            return true;
        }
    }
}

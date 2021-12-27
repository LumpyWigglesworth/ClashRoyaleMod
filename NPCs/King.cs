using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using Terraria.Localization;
using ClashRoyaleMod.Items.Chests;
using ClashRoyaleMod.Items;

namespace ClashRoyaleMod.NPCs
{
    [AutoloadHead]
    public class King : ModNPC
    {
        public override string Texture => "ClashRoyaleMod/NPCs/King";
        public override string[] AltTextures => new[] { "ClashRoyaleMod/NPCs/King_Alt_1" };

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 26;
            NPCID.Sets.ExtraFramesCount[npc.type] = 10;
            NPCID.Sets.AttackFrameCount[npc.type] = 5;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 1;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
        }
        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 15;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.Guide;
        }
        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            if (money >= Item.sellPrice(gold: 1))
                return true;
            else
                return false;
        }
        public override string TownNPCName()
        {
            switch (WorldGen.genRand.Next(6))
            {
                case 0:
                    return "Charles";
                case 1:
                    return "Henry";
                case 2:
                    return "George";
                case 3:
                    return "Richard";
                case 4:
                    return "James";
                case 5:
                    return "William";
                default:
                    return "Edward";
            }
        }
        public override string GetChat()
        {
            switch (Main.rand.Next(4))
            {
                case 0:
                    return "HEHEHEHA :D!";
                case 1:
                    return "AH HUH HUH HWEE ;(!";
                case 2:
                    return "HAHAAA :)!";
                default:
                    return "GRRRRRR >:(";
            }
        }
        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Language.GetTextValue("LegacyInterface.28");
        }
        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {
                shop = true;
            }
        }
        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<LegendaryChest>());
        }
        public override bool CanGoToStatue(bool toKingStatue)
        {
            return true;
        }
        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 20;
            knockback = 4f;
        }
        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 30;
            randExtraCooldown = 30;
        }
        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.CannonballFriendly;
            attackDelay = 1;
        }
        public override void TownNPCAttackShoot(ref bool inBetweenShots)
        {
            inBetweenShots = true;
        }
        public override void DrawTownAttackGun(ref float scale, ref int item, ref int closeness)
        {
            item = ModContent.ItemType<KingsCannon>();
        }
        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 12f;
            randomOffset = 2f;
        }
    }
}

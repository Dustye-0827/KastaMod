using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Kasta.NPCs
{
    public class KastaGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == ModContent.NPCType<Bosses.CaveDemolisherHead>())
            {
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.WormScale>(), Main.rand.Next(13, 24));
                }
            }
            //if (npc.type == NPCID.SkeletronHead)
            {
               //if (Main.rand.NextBool(1))   //item rarity
                {
                  // Item.NewItem(npc.getRect(), ItemID.BoneSword);
                }
            }
        }
    }
}
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace Kasta.NPCs
{
    public class KastaSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kasta Slime");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[2];
        }
        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 15;
            npc.damage = 19;
            npc.defense = 6;
            npc.lifeMax = 100;
            npc.value = 50f;
            npc.aiStyle = 1;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            aiType = NPCID.GreenSlime;
            animationType = NPCID.GreenSlime;
            npc.scale = 1f;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (NPC.downedBoss1)
            {
                return SpawnCondition.OverworldDay.Chance * 0.5f;
            }
            else
            {
                return SpawnCondition.OverworldDay.Chance * 0f;
            }
        }

        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter++;
            if (npc.frameCounter >= 20)
            {
                npc.frameCounter = 0;
            }
            npc.frame.Y = (int)npc.frameCounter / 10 * frameHeight;
        }

        public override void NPCLoot()
        {
            Item.NewItem(npc.getRect(), ItemID.Gel, Main.rand.Next(0, 5));
        }
    }
}

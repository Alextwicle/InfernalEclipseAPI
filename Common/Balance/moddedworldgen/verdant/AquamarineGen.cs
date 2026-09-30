using Terraria.GameContent.Generation;
using Terraria.IO;
using Terraria.WorldBuilding;
using InfernalEclipseAPI.Core.Configs;
using Verdant.Tiles.Verdant.Basic.Aquamarine;
using ThoriumMod.Items.Placeable;
using Verdant;
using Thorium;

namespace InfernalEclipseAPI.Common.Balance.moddedworldgen.verdant
{
    public class AquamarineGen
    {
        public static void AquamarineGenSwap()
        {
            if (ModLoader.TryGetMod("Verdant", out Mod Verdant) && ModLoader.TryGetMod("Thorium", out Mod Thorium))
            {
                for (int i = 0; GenVars.orePatchX.Length > 0; i++)
                {
                    if (GenVars.orePatchX[i] == Verdant.Find<ModTile>("EmbeddedAquamarine").Type)
                    {
                        WorldGen.PlaceTile(i,i, Thorium.Find<ModTile>("AquamarineStoneBlock").Type);
                    }
                }
            }
        }
    }
}
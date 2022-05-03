using Microsoft.Xna.Framework;
using StardewValley;
using HarmonyLib;


namespace HaltEventTime.Patches
{
    [HarmonyPatch(typeof(Buff), "update")]
    public class BuffUpdatePatch
    {
        public static bool Disable = true;
        public static bool Prefix(ref bool __result, ref GameTime time)
        {
            //这边return true代表不阻止源方法
            if (!Disable)
                __result = false;
            return Disable;
        }
    }
}

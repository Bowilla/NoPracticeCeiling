using HarmonyLib;
using MelonLoader;

namespace NoPracticeCeiling
{
    public class NoPracticeCeilingMod : MelonMod
    {


    }

    [HarmonyPatch(typeof(PlayerController), nameof(PlayerController.LimitPracticeHeight))]
    public class Patch
    {
        static bool Prefix(PlayerController __instance)
        {
            __instance.practiceModeBarrier.SetActive(false);
            return false;
        }
    }
}

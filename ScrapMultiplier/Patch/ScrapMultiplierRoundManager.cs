using HarmonyLib;
using UnityEngine;

namespace ScrapMultiplier
{
    [HarmonyPatch(typeof(RoundManager))]
    public static class ScrapMultiplierRoundManager
    {
        [HarmonyPatch("SpawnScrapInLevel")]
        [HarmonyPrefix]
        public static void SpawnScrapInLevelPrefix(RoundManager __instance)
        {
            __instance.scrapAmountMultiplier = ScrapMultiplierPlugin.ScrapMultiplierConfig.Value;
        }
    }
}

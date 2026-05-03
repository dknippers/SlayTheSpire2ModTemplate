using HarmonyLib;
using MegaCrit.Sts2.Core.Models.Cards;

namespace ModName.Patches;

[HarmonyPatch]
public static class ModifyIroncladStrikeDamage
{
    [HarmonyPatch(typeof(StrikeIronclad), MethodType.Constructor)]
    [HarmonyPostfix]
    public static void StrikeIronclad_Constructor(StrikeIronclad __instance)
    {
        // Modify damage: 6 -> 10
        __instance.DynamicVars.Damage.BaseValue = 10m;
    }
}

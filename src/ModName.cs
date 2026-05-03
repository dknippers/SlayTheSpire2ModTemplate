using HarmonyLib;
using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Modding;

namespace ModName;

[ModInitializer(nameof(Init))]
public static class ModName
{
    public static void Init()
    {
        var harmony = new Harmony(nameof(ModName));
        harmony.PatchAll(typeof(ModName).Assembly);

        Log.Info("ModName loaded successfully");
    }
}

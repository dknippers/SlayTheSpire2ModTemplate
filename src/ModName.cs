using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Modding;

namespace ModName;

[ModInitializer(nameof(Init))]
public static class ModName
{
    public static void Init()
    {
        Log.Info("ModName loaded successfully");
    }
}

using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using MyLethalCompanyMod.Patches;

using static MyLethalCompanyMod.MyPluginInfo;

namespace MyLethalCompanyMod;

[BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
public class MyPlugin : BaseUnityPlugin
{
    public static new ManualLogSource Logger;

    void Awake()
    {
        Logger = base.Logger;

        var harmony = new Harmony(PLUGIN_GUID);
        // harmony.PatchAll() will have same effect
        harmony.PatchAll(typeof(SayHello));

        Logger.LogInfo($"Plugin {PLUGIN_GUID} is loaded!");
    }
}
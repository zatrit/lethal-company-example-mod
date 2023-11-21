using BepInEx.Logging;
using HarmonyLib;

using static MyLethalCompanyMod.MyPluginInfo;

namespace MyLethalCompanyMod.Patches;

// Injection into Awake method from MenuManager class
[HarmonyPatch(typeof(MenuManager), "Awake")]
public class SayHello
{
    static readonly ManualLogSource logger = Logger.CreateLogSource(PLUGIN_GUID);

    static void Prefix()
    {
        logger.LogInfo("Hello from menu!");
    }
}
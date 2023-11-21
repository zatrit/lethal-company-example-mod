using HarmonyLib;

using static MyLethalCompanyMod.Plugin;

namespace MyLethalCompanyMod.Patches;

// Injection into Awake method from MenuManager class
[HarmonyPatch(typeof(MenuManager), "Awake")]
public class SayHello
{
    static void Prefix()
    {
        Logger.LogInfo("Hello from menu!");
    }
}
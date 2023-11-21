using HarmonyLib;

namespace MyLethalCompanyMod.Patches;

// Injection into Awake method from MenuManager class
[HarmonyPatch(typeof(MenuManager), "Awake")]
public class SayHello
{
    static void Prefix()
    {
        Plugin.Logger.LogInfo("Hello from menu!");
    }
}
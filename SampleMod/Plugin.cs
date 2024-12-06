using BepInEx;
using HarmonyLib;

[BepInPlugin("author.sample_mod", "Sample Mod", "1.0.0")]
public class Plugin : BaseUnityPlugin
{
    public void OnStartCore()
    {
        var harmony = new Harmony("author.sample_mod");
        harmony.PatchAll();
    }
}

[HarmonyPatch(typeof(Scene))]
[HarmonyPatch(nameof(Scene.Init))]
class ScenePatch
{
    static void Postfix(Scene.Mode newMode)
    {
        if (newMode == Scene.Mode.StartGame)
        {
            Msg.NewLine();
            Msg.SayRaw("Hello, World!");
        }
    }
}

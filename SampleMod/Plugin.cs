using System.IO;
using BepInEx;

[BepInPlugin("author.sample_mod", "Sample Mod", "1.0.0.0")]
public class Plugin : BaseUnityPlugin
{
    public void OnStartCore()
    {
        var dir = Path.GetDirectoryName(Info.Location);
        var excel = dir + "/SourceCard.xlsx";
        var sources = Core.Instance.sources;
        ModUtil.ImportExcel(excel, "Chara", sources.charas);
        ModUtil.ImportExcel(excel, "CharaText", sources.charaText);
        ModUtil.ImportExcel(excel, "Thing", sources.things);
    }
}

using BepInEx;
using UniverseLib;
using UniverseLib.UI;
using UniverseLib.UI.Panels;
using UnityEngine;
using UnityEngine.UI;
using Noname.Worldless.Navigation;

namespace WorldlessCheatWindow;
public class Ui : PanelBase
{
    public Ui(UIBase owner) : base(owner) { }
    public override string Name => "Cheat Panel";
    public override int MinWidth => 100;
    public override int MinHeight => 100;
    public override Vector2 DefaultAnchorMin => new(0.25f, 0.25f);
    public override Vector2 DefaultAnchorMax => new(0.75f, 0.75f);
    public override bool CanDragAndResize => true;

    protected override void ConstructPanelContent()
    {
        Text shineLabel = UIFactory.CreateLabel(ContentRoot, "shineLabel", "Unlock Shine");
        UIFactory.SetLayoutElement(shineLabel.gameObject, minWidth: 200, minHeight: 25);

        Toggle grantShine;
        UIFactory.CreateToggle(ContentRoot, "grantShine", out grantShine, out _);
        grantShine.onValueChanged.AddListener(delegate { AbilityManager.Set(Skill.Shine, grantShine.isOn); });


        Text ShootingStarLabel = UIFactory.CreateLabel(ContentRoot, "shootingStarLabel", "Unlock Shooting Star");
        UIFactory.SetLayoutElement(ShootingStarLabel.gameObject, minWidth: 200, minHeight: 25);

        Toggle grantShootingStar;
        UIFactory.CreateToggle(ContentRoot, "grantShootingStar", out grantShootingStar, out _);
        grantShootingStar.onValueChanged.AddListener(delegate { AbilityManager.Set(Skill.ShootingStar, grantShootingStar.isOn); });


        Text snatchLabel = UIFactory.CreateLabel(ContentRoot, "snatchLabel", "Unlock Snatch");
        UIFactory.SetLayoutElement(snatchLabel.gameObject, minWidth: 200, minHeight: 25);

        Toggle grantSnatch;
        UIFactory.CreateToggle(ContentRoot, "grantSnatch", out grantSnatch, out _);
        grantSnatch.onValueChanged.AddListener(delegate { AbilityManager.Set(Skill.Snatch, grantSnatch.isOn); });


        Text switchLabel = UIFactory.CreateLabel(ContentRoot, "switchLabel", "Unlock Switch");
        UIFactory.SetLayoutElement(switchLabel.gameObject, minWidth: 200, minHeight: 25);

        Toggle grantSwitch;
        UIFactory.CreateToggle(ContentRoot, "grantSwitch", out grantSwitch, out _);
        grantSwitch.onValueChanged.AddListener(delegate { AbilityManager.Set(Skill.Switch, grantSwitch.isOn); });


        Text noclipLabel = UIFactory.CreateLabel(ContentRoot, "noclipLabel", "Enable Noclip");
        UIFactory.SetLayoutElement(switchLabel.gameObject, minWidth: 200, minHeight: 25);

        Toggle grantNoclip;
        UIFactory.CreateToggle(ContentRoot, "grantNoclip", out grantNoclip, out _);
        grantNoclip.onValueChanged.AddListener(delegate { AbilityManager.Noclip(grantNoclip.isOn); });
       
    }

    internal static string GUID = "moff.cheatwindow";
    internal static void UpdateUI()
    {
        

    }

}

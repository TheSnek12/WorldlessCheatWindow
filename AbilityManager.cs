using Noname.Worldless.Navigation;
using UnityEngine;

namespace WorldlessCheatWindow;
public class AbilityManager
{
    internal static bool noclipping { get; private set; }
    internal static void Set(Skill skill, bool state)
    {
        SkillsProgression skillsProgression = GameObject.Find("NavigationSystem(Clone)").GetComponent<NavigationProgression>().skills;
        skillsProgression.saveData.unlockedSkills[skill] = state;
    }
    internal static bool Get(Skill skill)
    {
        SkillsProgression skillsProgression = GameObject.Find("NavigationSystem(Clone)").GetComponent<NavigationProgression>().skills;
        return skillsProgression.saveData.unlockedSkills[skill];
    }

    internal static void Noclip(bool enabled)
    {
        noclipping = enabled;
        GameObject.Find("BaseNavigation").GetComponent<NavigationController>().enabled = !enabled;
    }
}
using BepInEx;
using LeaderBaordColors.Behaviors;

namespace LeaderBaordColors
{
    [BepInPlugin(Constants.GUID, Constants.Name, Constants.Version)]
    public class Plugin : BaseUnityPlugin
    {
        private Plugin()
        {
            gameObject.AddComponent<BoardManager>();
            gameObject.AddComponent<ColorManager>();

            ConfigManager.CreateConfig();
        }
    }
}
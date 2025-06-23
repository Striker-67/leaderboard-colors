using BepInEx.Configuration;
using BepInEx;
using System.IO;

namespace LeaderBaordColors.Behaviors
{
    class ConfigManager
    {
        private static ConfigFile config;
        public static ConfigEntry<string> Color;

        public static void CreateConfig()
        {
            config = new ConfigFile(Path.Combine(Paths.ConfigPath, "LeaderboardColors.cfg"), true);
            Color = config.Bind(
                "Settings",
                "BoardColor",
                "playercolor",
                "This is what color the board will be!\n" +
                "Enter a hex color like #ff5733.\n" +
                "Or enter 'playercolor' to match your players color."
            );
        }
    }
}
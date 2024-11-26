using System;
using HugsLib;
using HugsLib.Settings;
using Verse;

namespace MyHugsLibMod
{
    public class MyHugsLibMod : ModBase
    {
        // Define the Mod Settings
        public override string ModIdentifier => "MyHugsLibMod";

        // Settings variables
        private SettingHandle<int> settingInteger;
        private SettingHandle<bool> settingToggle;

        public override void DefsLoaded()
        {
            // Initialize settings
            settingInteger = Settings.GetHandle(
                "settingInteger", // Unique identifier
                "Example Integer Setting", // Title
                "This is an example integer setting.", // Description
                10, // Default value
                Validators.IntRangeValidator(1, 100) // Validate range 1-100
            );

            settingToggle = Settings.GetHandle(
                "settingToggle", // Unique identifier
                "Example Toggle Setting", // Title
                "This is an example toggle setting.", // Description
                true // Default value
            );
        }

        public override void Tick(int currentTick)
        {
            // Example: Log a message every 10,000 ticks if toggle is enabled
            if (currentTick % 10000 == 0 && settingToggle)
            {
                Log.Message($"MyHugsLibMod: Current integer value is {settingInteger}.");
            }
        }
    }
}

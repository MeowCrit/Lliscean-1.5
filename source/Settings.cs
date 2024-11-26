public class Setting : ModBase
{
    public override string ModIdentifier
    {
        get { return "SettingTest"; }
    }
    private SettingHandle<bool> toggle;
    public override void DefsLoaded()
    {
        toggle = Settings.GetHandle<bool>(
            "myToggle",
            "toggleSetting_title".Translate(),
            "toggleSetting_desc".Translate(),
            false);
    }
    var dangerLevel = Settings.GetHandle("dangerLevel", "Danger level", "Description here...",
    0, Validators.IntRangeValidator(0, 100));
    dangerLevel.ContextMenuEntries = new[] {
    new ContextMenuEntry("Preset: Low", () => dangerLevel.Value = 10),
    new ContextMenuEntry("Preset: Medium", () => dangerLevel.Value = 50),
    new ContextMenuEntry("Preset: High", () => dangerLevel.Value = 80)
};
[StaticConstructorOnStartup]
}
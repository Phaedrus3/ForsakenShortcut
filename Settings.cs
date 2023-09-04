using ModSettings;

namespace ForsakenShortcut
{
    internal class ForsakenShortcut : JsonModSettings
    {
        //Blackrock
        [Section("Forsaken Shortcut")]

        [Name("Enable")]
        [Description("Enable the Shorcut.")]
        public bool FASCEnable = false;


        protected override void OnConfirm()
        {
            base.OnConfirm();

            Patches.ChangeObjects();
        }

    }

    internal static class Settings
    {
        public static ForsakenShortcut options;

        public static void OnLoad()
        {
            options = new ForsakenShortcut();
            options.AddToModSettings("Forsaken Shortcut", MenuType.Both);
        }
    }

}
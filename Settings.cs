namespace ForsakenShortcut
{
    internal class Settings : JsonModSettings
    {
        public static Settings Instance { get; } = new();

        //Blackrock
        [Section("Forsaken Shortcut")]

        [Name("Enable")]
        [Description("Enable the Shorcut.")]
        public bool FASCEnable = false;

        protected override void OnConfirm()
        {
            base.OnConfirm();

            Main.AddRemoveBridges(Instance.FASCEnable);
        }

        public static void OnLoad()
        {
            Instance.AddToModSettings("Forsaken Shortcut");
        }
    }
}
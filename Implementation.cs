using MelonLoader;
using UnityEngine;


namespace ForsakenShortcut
{
    internal class Main : MelonMod
    {
        public static bool BridgesAdded { get; set; } = false;

        public override void OnInitializeMelon()
        {
            Settings.OnLoad();/// ModSettings
            LoggerInstance.Msg($"Version {BuildInfo.Version}");

        }

        public override void OnSceneWasInitialized(int level, string name)
        {
            if (name == "AirfieldRegion")
            {



            }


            Patches.ChangeObjects();
        }

        public static void Aaa()
        {
            MelonLogger.Msg("Debug Log ========================== Aaa = ");

        }

    }
}
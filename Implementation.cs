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

        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            if (Settings.Instance.FASCEnable)
            {
                AddRemoveBridges(true);
            }
        }

        {
            {








    }
}
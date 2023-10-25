using ForsakenShortcut.Utilities.Exceptions;

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

        /// <summary>
        /// Adds the preset bridges to the required locations
        /// </summary>
        /// <param name="add">Weither to add or remove</param>
        /// <returns></returns>
        /// <exception cref="BadMemeException"></exception>
        public static bool AddRemoveBridges(bool add)
        {
            if (GameManager.m_ActiveScene != "AirfieldRegion") return false;
            if (BridgesAdded) return true;

            if (add)
            {
                GameObject BridgePrefab = GameObject.Find("STR_BridgeB_mid_Prefab");

                if (BridgePrefab == null) return false;

                try
                {
                    GameObject BridgeOne = GameObject.Instantiate(
                        BridgePrefab,
                        new(486.7615f, 270.4191f, -1238.576f),
                        Quaternion.Euler(3.6388f, 221.9289f, 29.2899f)
                    );

                    BridgeOne.name = "BridgeOne";
                    BridgeOne.transform.localScale = new(0.7f, 1f, 0.3f);
                }
                catch (Exception e)
                {
                    throw new BadMemeException($"Attempting to create BridgeOne failed due to {e.Message}");
                }

                try
                {
                    GameObject BridgeTwo = GameObject.Instantiate(
                        BridgePrefab,
                        new(222.7576f, 307.1439f, -1322.576f),
                        Quaternion.Euler(2.5097f, 130f, 21.7194f));

                    BridgeTwo.name = "BridgeTwo";
                    BridgeTwo.transform.localScale = new(1.9f, 0.3f, 0.2f);
                }
                catch (Exception e)
                {
                    throw new BadMemeException($"Attempting to create BridgeTwo failed due to {e.Message}");
                }

                try
                {
                    GameObject BridgeThree = GameObject.Instantiate(
                        BridgePrefab,
                        new(120.2315f, 320.9217f, -1269.832f),
                        Quaternion.Euler(359.8742f, 53.0764f, 349.6733f));

                    BridgeThree.name = "BridgeThree";
                    BridgeThree.transform.localScale = new(0.6f, 0.3f, 0.2f);
                }
                catch (Exception e)
                {
                    throw new BadMemeException($"Attempting to create BridgeThree failed due to {e.Message}");
                }

                try
                {
                    GameObject BridgeFour = GameObject.Instantiate(
                        BridgePrefab,
                        new(297.7316f, 278.089f, -1004.431f),
                        Quaternion.Euler(5.097f, 151.2446f, 40.7302f));

                    BridgeFour.name = "BridgeFour";
                    BridgeFour.transform.localScale = new(1, 0.5f, 0.2f);
                }
                catch (Exception e)
                {
                    throw new BadMemeException($"Attempting to create BridgeFour failed due to {e.Message}");
                }

                try
                {
                    GameObject BridgeFive = GameObject.Instantiate(
                        BridgePrefab,
                        new(283.6992f, 289.5107f, -1015.868f),
                        Quaternion.Euler(354.5169f, 312.7885f, 349.6733f));

                    BridgeFive.name = "BridgeFive";
                    BridgeFive.transform.localScale = new(0.4f, 0.3f, 0.2f);
                }
                catch (Exception e)
                {
                    throw new BadMemeException($"Attempting to create BridgeFive failed due to {e.Message}");
                }

                BridgesAdded = true;
                return true;
            }
            else
            {
                try
                {
                    GameObject.Destroy(GameObject.Find("BridgeOne"));
                    GameObject.Destroy(GameObject.Find("BridgeTwo"));
                    GameObject.Destroy(GameObject.Find("BridgeThree"));
                    GameObject.Destroy(GameObject.Find("BridgeFour"));
                    GameObject.Destroy(GameObject.Find("BridgeFive"));
                }
                catch (Exception e)
                {
                    throw new BadMemeException($"Attempting to destroy Bridges failed due to {e.Message}");
                }

                return true;
            }
        }
    }
}
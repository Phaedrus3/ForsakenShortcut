using UnityEngine;
using Il2Cpp;

namespace ForsakenShortcut
{
    public class Patches : MonoBehaviour                               //public class Patches:MonoBehaviour
    {


        public static string[,] itemDataArray =
        {
            //OBJECTS
            {"0_Delete","1_Scene",              "2_Name",                               "3_EulerY", "4_Position" },

            //Forsaken Airfield
            {"false",   "AirfieldRegion",        "STR_BridgeB_mid_Prefab",             "276.8639",       "-609.3, 172.03, -638.87"},
            {"false",   "AirfieldRegion",        "Art/Signs/OBJ_AirfieldSignC_Prefab    ",             "1.0728, 182.0879, 355.9392",       "-1016.03, 237.5771, -1185.533"},
            {"false",   "AirfieldRegion",        "Art/Signs/OBJ_AirfieldSignC_Prefab Variant",             "0.4774, 219.3775, 5.4382",       "-616.5717, 173.2682, -710.8884"},




        };

        public static void ChangeObjects()
        {

            GameObject findTargetGO = new GameObject();


            for (int i = 1; i < itemDataArray.GetLength(0); i++)
            {
                // ----- Find Name -----------------------------------------------------------------
                if (GameObject.Find(itemDataArray[i, 2]) == null)
                {
                    //MelonLogger.Msg("ChangeObjcet is null.");
                    continue;
                }
                else
                {
                    findTargetGO = GameObject.Find(itemDataArray[i, 2]);
                    // GameObject.Find cannot find for already inactive game objects. So this needs to be reloaded after confermation.
                }
                // -------------------------------------------------------------------------------------


                if (findTargetGO != null)
                {
                    // ----- Scene check -----------------------------------------------------------------
                    if (findTargetGO.scene.name != itemDataArray[i, 1]) // Scene 
                    {
                        //MelonLogger.Msg("Scene name does not match.");
                        continue;
                    }
                    // -------------------------------------------------------------------------------------



                    // ==============================================================================================================
                    // Forsaken Airfield
                    // ==============================================================================================================
                    if (itemDataArray[i, 1] == "AirfieldRegion")
                    {

                        // Entrance Bridge ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "STR_BridgeB_mid_Prefab")
                        {
                            if (Settings.options.FASCEnable)
                            {
                                if (GameObject.Find("STR_BridgeB_mid_Prefab(Clone)1"))
                                {
                                    continue;
                                }
                                else
                                {
                                    GameObject cloneObject = Instantiate(  // #Instantiate: clone to gameobject (MonoBehaviour)
                                        findTargetGO,
                                        new Vector3(486.7615f, 270.4191f, -1238.576f),
                                        Quaternion.Euler(3.6388f, 221.9289f, 29.2899f)
                                        );
                                    cloneObject.transform.localScale = new Vector3(0.7f, 1f, 0.3f);
                                }
                            }
                            else
                            {
                                if (GameObject.Find("STR_BridgeB_mid_Prefab(Clone)1"))
                                {
                                    Destroy(GameObject.Find("STR_BridgeB_mid_Prefab(Clone)1"));
                                }
                            }
                        }
                        //--------------------------------------------------------------------------------------

                        // Above Rock Climbs Bridge ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "STR_BridgeB_mid_Prefab")
                        {
                            if (Settings.options.FASCEnable)
                            {
                                if (GameObject.Find("STR_BridgeB_mid_Prefab(Clone)2"))
                                {
                                    continue;
                                }
                                else
                                {
                                    GameObject cloneObject = Instantiate(  // #Instantiate: clone to gameobject (MonoBehaviour)
                                        findTargetGO,
                                        new Vector3(222.7576f, 307.1439f, -1322.576f),
                                        Quaternion.Euler(2.5097f, 130f, 21.7194f)
                                        );
                                    cloneObject.transform.localScale = new Vector3(1.9f, 0.3f, 0.2f);
                                }
                            }
                            else
                            {
                                if (GameObject.Find("STR_BridgeB_mid_Prefab(Clone)2"))
                                {
                                    Destroy(GameObject.Find("STR_BridgeB_mid_Prefab(Clone)2"));
                                }
                            }
                        }
                        //--------------------------------------------------------------------------------------

                        // Across Gap Bridge ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "STR_BridgeB_mid_Prefab")
                        {
                            if (Settings.options.FASCEnable)
                            {
                                if (GameObject.Find("STR_BridgeB_mid_Prefab(Clone)3"))
                                {
                                    continue;
                                }
                                else
                                {
                                    GameObject cloneObject = Instantiate(  // #Instantiate: clone to gameobject (MonoBehaviour)
                                        findTargetGO,
                                        new Vector3(120.2315f, 320.9217f, -1269.832f),
                                        Quaternion.Euler(359.8742f, 53.0764f,  349.6733f)
                                        );
                                    cloneObject.transform.localScale = new Vector3(.6f, .3f, .2f);
                                }
                            }
                            else
                            {
                                if (GameObject.Find("STR_BridgeB_mid_Prefab(Clone)3"))
                                {
                                    Destroy(GameObject.Find("STR_BridgeB_mid_Prefab(Clone)3"));
                                }
                            }
                        }
                        //--------------------------------------------------------------------------------------

                        // AF Side Lower Bridge ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "STR_BridgeB_mid_Prefab")
                        {
                            if (Settings.options.FASCEnable)
                            {
                                if (GameObject.Find("STR_BridgeB_mid_Prefab(Clone)4"))
                                {
                                    continue;
                                }
                                else
                                {
                                    GameObject cloneObject = Instantiate(  // #Instantiate: clone to gameobject (MonoBehaviour)
                                        findTargetGO,
                                        new Vector3(297.7316f, 278.089f, -1004.431f),
                                        Quaternion.Euler(5.097f, 151.2446f, 40.7302f)
                                        );
                                    cloneObject.transform.localScale = new Vector3(1, .5f, .2f);
                                }
                            }
                            else
                            {
                                if (GameObject.Find("STR_BridgeB_mid_Prefab(Clone)4"))
                                {
                                    Destroy(GameObject.Find("STR_BridgeB_mid_Prefab(Clone)4"));
                                }
                            }
                        }
                        //--------------------------------------------------------------------------------------

                        
                        // AF Side Upper Bridge ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "STR_BridgeB_mid_Prefab")
                        {
                            if (Settings.options.FASCEnable)
                            {
                                if (GameObject.Find("STR_BridgeB_mid_Prefab(Clone)5"))
                                {
                                    continue;
                                }
                                else
                                {
                                    GameObject cloneObject = Instantiate(  // #Instantiate: clone to gameobject (MonoBehaviour)
                                        findTargetGO,
                                        new Vector3(283.6992f, 289.5107f, -1015.868f),
                                        Quaternion.Euler(354.5169f, 312.7885f, 349.6733f)
                                        );
                                    cloneObject.transform.localScale = new Vector3(0.4f, 0.3f, 0.2f);
                                }
                            }
                            else
                            {
                                if (GameObject.Find("STR_BridgeB_mid_Prefab(Clone)5"))
                                {
                                    Destroy(GameObject.Find("STR_BridgeB_mid_Prefab(Clone)5"));
                                }
                            }
                        }
                        //--------------------------------------------------------------------------------------
                        
                    }


                }

            }

        }

    }
}
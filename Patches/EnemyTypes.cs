using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using LC_API;
using UnityEngine;

namespace ArachnophobiaMod.patches
{
    [HarmonyPatch]
    class EnemyTypes
    {
        [HarmonyPatch(typeof(SandSpiderAI), "Start")]
        [HarmonyPostfix]
        public static void SummonGok(SandSpiderAI __instance)
        {
            
            GameObject.Destroy(__instance.gameObject.transform.Find("MeshContainer/MeshRenderer").gameObject.GetComponent<SkinnedMeshRenderer>());
            GameObject Gok = UnityEngine.Object.Instantiate(LC_API.BundleAPI.BundleLoader.GetLoadedAsset<GameObject>("assets/Gok.prefab"), __instance.gameObject.transform);
            Gok.transform.localPosition = new Vector3(0f, 1.5f, 0f);
            
            
        }
    }
}

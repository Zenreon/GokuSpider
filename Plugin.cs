
using BepInEx;
using HarmonyLib;


namespace ArachnophobiaMod
{
    [BepInPlugin("com.zenreon.ArachnophobiaMod", "ArachnophobiaMod", "1.0.0" )]
    public class Plugin : BaseUnityPlugin
    {
        public Harmony harmonymain;
        private void Awake()
        {
            harmonymain = new Harmony("com.zenreon.ArachnophobiaMod");
            harmonymain.PatchAll();
            Logger.LogInfo($"Arachnophobia mod loaded.");
        }
    }
}

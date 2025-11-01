using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using JetBrains.Annotations;
using PotionCraft.ScriptableObjects.Ingredient;
using PotionCraft.ManagersSystem;
using UnityEngine;
using UnityEngine.InputSystem;
using PotionCraft.InputSystem;

namespace PotionCraftAPMod;

[BepInPlugin("com.pinkandsparkle10.PotionCraftAPMod", "PotionCraftAPMod", "0.1.0")]
public class Plugin : BaseUnityPlugin
{
    public static new ManualLogSource Logger;
        
    private void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;
        Logger.LogInfo($"Plugin PotionCraftAPMod is loaded!");
        HarmonyLib.Harmony harmony = new("com.pinkandsparkle10.PotionCraftAPMod");
        //harmony.PatchAll(Assembly.GetExecutingAssembly());
    }

    private void Update()
    {
        if (Keyboard.current.f6Key.wasPressedThisFrame)
        {
            PotionCraft.ManagersSystem.Player.PlayerManager.AddGoldCommand(10);
        }
            
    }
  
}

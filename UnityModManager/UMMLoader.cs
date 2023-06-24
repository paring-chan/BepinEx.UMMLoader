using System;
using BepInEx;

namespace UnityModManagerNet;

/// <summary>
/// UMM Loader for bepinex
/// </summary>
[BepInPlugin("dev.pikokr.bepinex-ummloader", "Unity Mod Manager for BepinEx", "0.0.1")]
public class UMMLoader : BaseUnityPlugin
{
    private void Awake()
    {
        UnityModManager.Start();
    }

    private void Start()
    {
        UnityModManager.UI.Instance.FirstLaunch();
    }
}
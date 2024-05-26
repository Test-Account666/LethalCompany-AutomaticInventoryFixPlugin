using System;
using GameNetcodeStuff;
using HarmonyLib;
using MonoMod.Utils;
using UnityEngine;

namespace AutomaticInventoryFixPlugin.Patches;

[HarmonyPatch(typeof(PlayerControllerB))]
public static class PlayerControllerBFinalizer {
    [HarmonyPatch("SetObjectAsNoLongerHeld")]
    [HarmonyFinalizer]
    public static Exception SetObjectAsNoLongerHeldFinalizer(Exception __exception, GrabbableObject dropObject,
        Vector3 targetFloorPosition) {
        if (__exception == null!)
            return null!;

        AutomaticInventoryFixPlugin.Logger.LogInfo("Exception? " + (__exception != null!));

        AutomaticInventoryFixPlugin.Logger.LogWarning(
            "Catched Exception from PlayerControllerB#SetObjectAsNoLongerHeld method!");

        __exception.LogDetailed();

        AutomaticInventoryFixPlugin.Logger.LogWarning("More Information:");

        AutomaticInventoryFixPlugin.Logger.LogWarning("dropObject null? " + (dropObject == null));
        AutomaticInventoryFixPlugin.Logger.LogWarning("targetFloorPosition null? " + (targetFloorPosition == null!));

        if (dropObject == null)
            return null!;

        AutomaticInventoryFixPlugin.Logger.LogWarning("transform null? " + (dropObject.transform == null!));

        if (dropObject.transform == null)
            return null!;

        AutomaticInventoryFixPlugin.Logger.LogWarning("transform position null? " + dropObject.transform.position ==
                                                      null!);

        AutomaticInventoryFixPlugin.Logger.LogWarning(
            "transform parent null? " + (dropObject.transform.parent == null!));
        return null!;
    }
}
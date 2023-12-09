using HarmonyLib;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace IdeoApparelColors;
[HarmonyPatch]
public static class Patch {
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Ideo), nameof(Ideo.ApparelColor), MethodType.Getter)]
    public static void ApparelColor(Ideo __instance, ref Color __result) 
        => __result = __instance.Color;
}

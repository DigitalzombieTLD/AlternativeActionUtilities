using HarmonyLib;
using Il2Cpp;

namespace AlternativeActionUtilities.Patches
{
	[HarmonyPatch(typeof(PlayerManager), "InteractiveObjectsProcessInteraction")]
	internal static class PlayerManager_InteractiveObjectsProcessInteraction
	{
		internal static void Prefix(PlayerManager __instance)
		{
			AlternativeAction alternativeAction = __instance?.GetInteractiveObjectUnderCrosshairs(10f)?.GetComponent<AlternativeAction>();
			if (alternativeAction == null) return;

			alternativeAction.ExecutePrimary();
		}
	}

	[HarmonyPatch(typeof(PlayerManager), "InteractiveObjectsProcessAltFire")]
	internal static class PlayerManager_InteractiveObjectsProcessAltFire
	{
		internal static void Prefix(PlayerManager __instance)
		{
			AlternativeAction alternativeAction = __instance?.GetInteractiveObjectUnderCrosshairs(10f)?.GetComponent<AlternativeAction>();
			if (alternativeAction == null) return;

			alternativeAction.ExecuteSecondary();
		}
	}

	[HarmonyPatch(typeof(PlayerManager), "InteractiveObjectsProcess")]
	internal static class PlayerManager_InteractiveObjectsProcess
	{
		internal static void Postfix(PlayerManager __instance)
		{
			if (InputManager.GetKeyDown(InputManager.m_CurrentContext, Settings.instance.tertiaryKeyCode))
			{
				AlternativeAction alternativeAction = __instance?.GetInteractiveObjectUnderCrosshairs(10f)?.GetComponent<AlternativeAction>();
				if (alternativeAction == null) return;
				alternativeAction.ExecuteTertiary();
			}
		}
	}
}

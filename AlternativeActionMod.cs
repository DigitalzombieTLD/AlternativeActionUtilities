using MelonLoader;
using UnityEngine;
using Il2CppInterop;
using Il2CppInterop.Runtime.Injection; 
using System.Collections;


namespace AlternativeActionUtilities
{
	public class AlternativeActionMod : MelonMod
	{
        public override void OnApplicationStart()
        {
            Settings.instance.AddToModSettings("Alternative Action Settings");
        }

    }
}
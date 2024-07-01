using MelonLoader;
using UnityEngine;
using Il2CppInterop;
using Il2CppInterop.Runtime.Injection; 
using System.Collections;

namespace YesIKnow
{
	public class YesIKnowMain : MelonMod
	{
		public override void OnInitializeMelon()
		{
            Settings.OnLoad();
        }

		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
       


        }

        public override void OnUpdate()
		{

		}

    }
}
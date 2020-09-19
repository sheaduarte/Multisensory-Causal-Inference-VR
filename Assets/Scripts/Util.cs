using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CausalInfMSI
{
	public class Util : MonoBehaviour
	{
        public static void QuitRequest()
        {
            Debug.Log("Quit request");
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
                                                Application.Quit();
#endif
        }
    } 
}

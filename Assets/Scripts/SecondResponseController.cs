using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using UnityEngine;
using Valve.VR.InteractionSystem;

namespace CausalInfMSI
{
	public class SecondResponseController : MonoBehaviour
	{
		public GameObject[] secondResponseBlobs;
		private List<GameObject> shownList;
		public float dur = 2f;

		public void SpawnSecondResponseBlobs()
		{
			foreach (GameObject blob in secondResponseBlobs)
			{
				shownList = new List<GameObject>();
				GameObject shown = Instantiate(blob, blob.transform.position, blob.transform.rotation);
				GameObject.Destroy(shown, dur);
			}
		}

		public void DestroyAllObjects()
		{
			foreach (var item in shownList)
			{
				Destroy(item);
			}
		}
	}
}
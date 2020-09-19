using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using UnityEngine;
using Valve.VR.InteractionSystem;

namespace CausalInfMSI
{
	public class ResponseController : MonoBehaviour
	{
		public GameObject[] responseBlobs;
		private List<GameObject> shownList;
		public float dur = 2f;
		public LaserInput laserInput;
		public string response;

		public void SpawnResponseBlobs()
		{
			foreach (GameObject blob in responseBlobs)
			{
				shownList = new List<GameObject>();
				GameObject shown = Instantiate(blob, blob.transform.position, blob.transform.rotation);
				GameObject.Destroy(shown, dur);
				//string response = laserInput.GetResponseSelected();
			}
		}

		public void DestroyAllObjects()
		{
			foreach (var item in shownList)
			{
				Destroy(item, dur);
			}
		}
	}
}
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
		public float dur = 10f;
		public LaserInput laserInput;
		public string response;

		public void SpawnResponseBlobs()
		{
			shownList = new List<GameObject>();
			foreach (GameObject blob in responseBlobs)
			{				
				GameObject shown = Instantiate(blob, blob.transform.position, blob.transform.rotation);
				//GameObject.Destroy(shown, dur);
				shownList.Add(shown);
			}
		}
		public void PrintList()
		{
			Debug.Log("Printing List----------------");
			foreach (var x in shownList)
			{
				Debug.Log(x.ToString());
			}
			Debug.Log("----------------");
		}
		public void DestroyAllObjects()
		{
			PrintList();
			foreach (var item in shownList)
			{
				GameObject.Destroy(item);
			}
			PrintList();
		}
	}
}
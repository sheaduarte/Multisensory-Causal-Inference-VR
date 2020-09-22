using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

namespace CausalInfMSI
{
    public class SpawnController : MonoBehaviour
    {
        public GameObject[] stimObjects;
        public float spawnTime;
        public float stimulusDuration;
        //private bool keyPressed = false;
        private List<GameObject> objectList;
        public string stimulus;

        public void SpawnRandomStim()
        {
            objectList = new List<GameObject>();
            int stimIndex = Random.Range(0, stimObjects.Length);
            GameObject stim = Instantiate(stimObjects[stimIndex],
            stimObjects[stimIndex].transform.position,
            stimObjects[stimIndex].transform.rotation);
            stimulus = stim.transform.name;
            Debug.Log(stim.name);
            GameObject.Destroy(stim, stimulusDuration);
            objectList.Add(stim);
        }
        
        public string GetStimSpawned()
        {
            return objectList.ToString();
        }

        public void DestroyAllObjects()
        {
            foreach (var item in objectList)
            {
                Destroy(item);
            }
        }
    }
}



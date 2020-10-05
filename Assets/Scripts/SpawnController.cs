using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

namespace CausalInfMSI
{
    public class SpawnController : MonoBehaviour
    {
        //public GameObject[] stimObjects;
        private List<GameObject> stimObjects;
        public float spawnTime;
        public float stimulusDuration;
        //private bool keyPressed = false;
        private string stimulus;

        public void SpawnRandomStim()
        {
            if(stimObjects.Length != 0)
            {
                int stimIndex = Random.Range(0, stimObjects.Length);
                GameObject stim = Instantiate(stimObjects[stimIndex],
                    stimObjects[stimIndex].transform.position,
                    stimObjects[stimIndex].transform.rotation);
                stimulus = stim.transform.name;
                Debug.Log(stim.name);
                stimObjects.Remove(stim);
            }
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

        public void setStimObjects(GameObject[] stimObject)
        {
            //stimObjects = stimObject;

            stimObjects = new List<GameObject>();

            foreach(GameObject obj in stimObject)
            {
                stimObjects.Add(obj);
            }
        }
    }
}



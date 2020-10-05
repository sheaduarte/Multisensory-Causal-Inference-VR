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
        public List<GameObject> stimObjects;
        public float spawnTime;
        public float stimulusDuration;
        //private bool keyPressed = false;
        private string stimulus;

        public void SpawnRandomStim()
        {
            if(stimObjects.Count != 0)
            {
                int stimIndex = Random.Range(0, stimObjects.Count - 1);
                GameObject stim = Instantiate(stimObjects[stimIndex],
                    stimObjects[stimIndex].transform.position,
                    stimObjects[stimIndex].transform.rotation);
                stimulus = stim.transform.name;
                Debug.Log(stim.name);
                stimObjects.Remove(stimObjects[stimIndex]);
                Destroy(stim, stimulusDuration);
                PrintList();
            }
        }

        public void PrintList()
        {
            foreach (var x in stimObjects)
            {
                Debug.Log(x.ToString());
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
            PrintList();
            Debug.Log("-----------");
        }

        public string getStimulus()
        {
            return stimulus;
        }


        //public string GetStimSpawned()
        //{
        //    return objectList.ToString();
        //}

        //public void DestroyAllObjects()
        //{
        //    foreach (var item in objectList)
        //    {
        //        Destroy(item);
        //    }
        //}

    }
}



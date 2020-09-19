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

        public void SpawnRandomStim()
        {
            objectList = new List<GameObject>();
            int stimIndex = Random.Range(0, stimObjects.Length);
            GameObject stim = Instantiate(stimObjects[stimIndex],
            stimObjects[stimIndex].transform.position,
            stimObjects[stimIndex].transform.rotation);
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



        //public void SpawnRandomStim()
        //{
        //    int stimIndex = Random.Range(0, stimObjects.Length);
        //    GameObject stim = Instantiate(stimObjects[stimIndex],
        //    stimObjects[stimIndex].transform.position,
        //    stimObjects[stimIndex].transform.rotation);
        //    GameObject.Destroy(stim, stimulusDuration);
        //}



        //public void update()
        //{

        //    if (input.getkeydown("space") && !keypressed)
        //    {
        //        spawninnewpos();
        //        keypressed = true;
        //        debug.log("pressed");
        //    }
        //    else if (input.getkeyup("space"))
        //    {
        //        keypressed = false;
        //    }
        //}
        //public void spawninnewpos()
        //{
        //    int objectindex = random.range(0, spawnposlist.length);
        //    gameobject stim = instantiate(spawnobject, spawnposlist[objectindex].position, quaternion.identity);
        //    gameobject.destroy(stim, stimulusduration);
        //}



        //public void DestroyAllObjects()
        //{
        //    if (Input.GetKeyDown(KeyCode.Space) && !_keyPressed)
        //    {
        //        //invokerepeating("spawninnewpos", spawntime, spawntime);
        //        SpawnInNewPos();
        //        _keyPressed = true;
        //        Debug.Log("pressed");
        //    }
        //    else if (Input.GetKeyUp(KeyCode.Space))
        //    {
        //        _keyPressed = false;
        //        foreach (var item in objectList)
        //        {
        //            Destroy(item);
        //        }
        //    }
        //}
    }
}



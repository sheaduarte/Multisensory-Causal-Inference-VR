using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class SpawnController : MonoBehaviour
{
    public GameObject spawnObject;
    public Transform[] spawnPosList;
    public float spawnTime;
    public float stimulusDuration;
    private bool keyPressed = false;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !keyPressed)
        {
            //invokerepeating("spawninnewpos", spawntime, spawntime);
            SpawnInNewPos();
            keyPressed = true;
            Debug.Log("pressed");
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            keyPressed = false;
        }

    }
    void SpawnInNewPos()
    {
        int objectIndex = Random.Range(0, spawnPosList.Length);
        GameObject stim = Instantiate(spawnObject, spawnPosList[objectIndex].position, Quaternion.identity);
        GameObject.Destroy(stim, stimulusDuration);
        
    }
}



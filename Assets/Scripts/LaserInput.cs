using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

namespace CausalInfMSI
{
    public class LaserInput : MonoBehaviour
    {
        public static GameObject currentObject;
        int currentID;
        public SteamVR_Action_Boolean onTriggerSqueeze;
        public SteamVR_Input_Sources handtype;
        public bool somethingSelected = false;
        public string response;
        public bool gotResponse = false;

        // For highlighting
        public int redCol;
        public int greenCol;
        public int blueCol;

        // Start is called before the first frame update
        void Start()
        {
            response = "false";
            currentObject = null;
            currentID = 0;
            onTriggerSqueeze.AddOnStateDownListener(OnViveTriggerDown, handtype);
        }

        // Update is called once per frame
        void Update()
        {
            RaycastHit[] hits;
            hits = Physics.RaycastAll(transform.position, transform.forward, 1000F);
            for (int i = 0; i < hits.Length; i++)
            {
                RaycastHit hit = hits[i];
                int id = hit.collider.gameObject.GetInstanceID();

                if (currentID != id)
                {
                    currentID = id;
                    currentObject = hit.collider.gameObject;
                }
            }
            
            if(onTriggerSqueeze.GetStateDown(SteamVR_Input_Sources.Any) && currentObject.transform.tag == "Response")
            {
                response = currentObject.transform.name;
                Debug.Log(response);
                gotResponse = true;
                currentObject.GetComponent<Renderer>().material.color = new Color32((byte)redCol, (byte)greenCol, (byte)blueCol, 255);
            }
            
        }

        public void OnViveTriggerDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources Any)
        {
            //string response = currentObject.transform.name;
            //Debug.Log(response);
            currentObject.GetComponent<Renderer>().material.color = new Color32((byte)redCol, (byte)greenCol, (byte)blueCol, 255);
        }

        //public string GetResponseSelected()
        //{
        //    if(somethingSelected == true)
        //    {
        //        //string response = currentObject.name;
        //        return response;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //    //return responses;           
        //}


    } 
}

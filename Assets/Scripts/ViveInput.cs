using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ViveInput : MonoBehaviour
{
    public SteamVR_Action_Boolean m_BooleanAction;

    private void Awake()
    {
        m_BooleanAction = SteamVR_Actions._default.GrabPinch;
    }
    private void Update()
    {
        if (m_BooleanAction.GetStateDown(SteamVR_Input_Sources.Any))
        {
            print("trigger enabled");
        }
    }
}

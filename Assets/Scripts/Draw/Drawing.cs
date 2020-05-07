using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Valve.VR;

public class Drawing : BaseInputModule
{
    public SteamVR_Input_Sources m_TargetSource;
    public SteamVR_Action_Boolean m_ClickAction;

    public override void Process()
    {

        if (m_ClickAction.GetStateDown(m_TargetSource))
            ProccessPress(1);
    }

    private void ProccessPress(int data) {
        Debug.Log("Press");
    }
}

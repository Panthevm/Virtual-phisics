using System.Collections;
using System.Collections.Generic;
using Valve.VR;
using UnityEngine;

public class Drawing : MonoBehaviour
{
    public SteamVR_Input_Sources m_TargetSource;
    public SteamVR_Action_Boolean m_ClickAction;
    public GameObject m_TrackedObj;
    public LineRenderer m_Line;

    private int numClicks = 0;

    public void Update()
    {

        if (m_ClickAction.GetStateDown(m_TargetSource))
        {
            Debug.Log("Press down");
            numClicks = 0;

        }
        else if (m_ClickAction.GetState(m_TargetSource))
        {
            m_Line.positionCount = numClicks + 1;
            m_Line.SetPosition(numClicks, m_TrackedObj.transform.position);
            numClicks++;
        }

    }
}

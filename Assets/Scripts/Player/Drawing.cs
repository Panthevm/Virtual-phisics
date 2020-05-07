using System.Collections;
using System.Collections.Generic;
using Valve.VR;
using UnityEngine;

public class Drawing : MonoBehaviour
{
    public SteamVR_Input_Sources m_TargetSource;
    public SteamVR_Action_Boolean m_ClickAction;
    public GameObject m_TrackedObj;
    public Material material;

    private LineRenderer line;

    private int numClicks = 0;

    public void Update()
    {

        if (m_ClickAction.GetStateDown(m_TargetSource))
        {
            GameObject go = new GameObject();
            line = go.AddComponent<LineRenderer>();

            line.SetWidth(0.03f, 0.04f);

            line.material = material;
            
            numClicks = 0;
        }

        else if (m_ClickAction.GetState(m_TargetSource))
        {
            line.positionCount = numClicks + 1;
            line.SetPosition(numClicks, m_TrackedObj.transform.position);
            numClicks++;
        }

    }
}

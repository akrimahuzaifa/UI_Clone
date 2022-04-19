using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnClickPanelControl : MonoBehaviour
{
    public GameObject hideOnClickPanel;
    bool isPanelActive = true;

    public void OnClickHidePanel()
    {
        if (isPanelActive)
        {
            hideOnClickPanel.SetActive(false);
            isPanelActive = false;
        }
        else
        {
            hideOnClickPanel.SetActive(true);
            isPanelActive = true;
        }     
    }
}

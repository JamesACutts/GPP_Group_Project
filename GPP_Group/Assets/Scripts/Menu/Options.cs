using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public Toggle fullscreenTog, vsyncTog;

    void Start()
    {
        fullscreenTog.isOn = Screen.fullScreen;
        
        if(QualitySettings.vSyncCount == 0)
        {
            vsyncTog.isOn = false;

        }
        else
        {
            vsyncTog.isOn = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApplyGrphics()
    {
        Screen.fullScreen = fullscreenTog.isOn;
        if(vsyncTog.isOn)
        {
            QualitySettings.vSyncCount = 1;
        }
        else
        {
            QualitySettings.vSyncCount = 0;
        }
    }
}

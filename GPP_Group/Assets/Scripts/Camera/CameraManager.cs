using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager instance;

    public Camera playerCamera;
    public Camera cutsceneCamera;

    private void Awake()
    {
        ShowPlayerCamera();
        instance = this;
    }
    public void ShowPlayerCamera()
    {
        playerCamera.enabled = true;
        cutsceneCamera.enabled = false;
    }
    public void ShowCutsceneCamera()
    {
        playerCamera.enabled = false;
        cutsceneCamera.enabled = true;;
    }
}

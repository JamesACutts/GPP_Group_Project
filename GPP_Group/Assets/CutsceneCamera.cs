using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneCamera : MonoBehaviour
{
    public static CutsceneCamera instance;
    public CameraManager camMan;
    public PlayerController player;
    public Transform newPos;
    public Transform lookPos;
    public float speed;

    private Vector3 startPos;

    public bool timerGoing = false;
    public bool played = false;
    public bool cameraChange = false;
    public bool cameraMove = false;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        startPos = transform.position;
        transform.LookAt(lookPos);
    }
    private void FixedUpdate()
    {
        if(cameraMove)
        {
            transform.LookAt(lookPos);
            float t = speed * Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, newPos.position, t);
        }
    }
    public IEnumerator Timer()
    {
        if(!played)
        {
            camMan.ShowCutsceneCamera();
            player.OnDisable();
            timerGoing = true;

            cameraMove = true;

            yield return new WaitForSeconds(2.5f);

            timerGoing = false;

            cameraChange = false;
            played = true;
            if(!timerGoing)
            {
                if(played)
                {
                    camMan.ShowPlayerCamera();
                    player.OnEnable();
                }
            }
        } 
    }
}

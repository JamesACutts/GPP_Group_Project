using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    public int GemsNeeded;

    [SerializeField] private Animator door = null;

    [SerializeField]private bool OpenButton = false;
    [SerializeField]private bool CloseButton = false;

    

    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(other.CompareTag("Player") && OpenButton && GemsNeeded <= playerInventory.NumberOfGems)
        {
            door.Play("DoorOpen", 0, 0.0f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        
        if(other.CompareTag("Player") && CloseButton && GemsNeeded <= playerInventory.NumberOfGems)
        {
            door.Play("DoorClose", 0, 0.0f);
        }
    }
}

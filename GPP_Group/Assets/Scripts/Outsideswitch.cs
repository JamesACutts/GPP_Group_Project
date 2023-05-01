using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Outsideswitch : MonoBehaviour

{
    public string Indoor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            {
            SceneManager.LoadScene(Indoor);
        }
    }
}

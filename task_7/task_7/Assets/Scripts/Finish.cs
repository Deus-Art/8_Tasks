using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject win;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
         Invoke("Win", 1.5f);
        }
    }

    void Win()
    {
            win.SetActive(true);
            Time.timeScale=0;
    }
}

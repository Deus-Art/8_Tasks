using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Collectables : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")) {
        
        Destroy(this.gameObject);
        }
    }
}

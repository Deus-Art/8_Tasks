using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag=="Player"){
            Debug.Log("Got it");
            
            Destroy(this.gameObject);
            

        }

    }
    
}

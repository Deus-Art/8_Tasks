using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanDestroyer : MonoBehaviour
{
   private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Destroy"))
        {
            Customers.instance.DestroyHuman();
        }
    }
}

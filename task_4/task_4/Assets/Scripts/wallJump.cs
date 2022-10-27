using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallJump : MonoBehaviour
{
    public float jump = 5f;
    //bool isKinematic=true;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("wall"))
        {
            this.gameObject.GetComponent<Rigidbody>().isKinematic=false;
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up*jump, ForceMode.Impulse);  
            //Invoke("Kinematic" ,2.5f);
        }
    }

    /*void Kinematic ()
    {
        isKinematic=true;
    }*/
}

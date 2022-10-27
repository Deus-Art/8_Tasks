using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothDamp : MonoBehaviour
{
    public Transform bond;
    float velo = 0f;
    float smoTime = 0.2f;
    

    private void Start() 
    {
        
    }

     public void SetLeadTransform(Transform leadTransform)
    {
        bond = leadTransform;
    }

     void FixedUpdate()
    {
           if (bond == null) 
           {return;}

           else
        {transform.position = new Vector3(Mathf.SmoothDamp(transform.position.x, bond.position.x, ref velo, smoTime), 
        transform.position.y, 
        transform.position.z);}
    }

    private void OnTriggerEnter(Collider other) {
           if(other.gameObject.CompareTag("Collect"))
        {
            Collector.instance.Collectable(other.gameObject);
            other.gameObject.GetComponent<BoxCollider>().isTrigger=false;
            other.gameObject.tag = "Collected";
        }
    }
}

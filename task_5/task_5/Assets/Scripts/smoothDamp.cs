using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoothDamp : MonoBehaviour
{
    public Transform bond;
    //public float bondSpeed = 100;

    float velo = 0f;
    float smoTime = .1f;
    //public int number;

    private void Start() 
    {
        //number = Collect.counter;
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
           
        
        
        /*transform.position = new Vector3(
            Mathf.Lerp(transform.position.x, bond.position.x, Time.deltaTime * bondSpeed),
            transform.position.y,
            transform.position.z
        );*/
        
    }

    private void OnTriggerEnter(Collider other) {
           if(other.gameObject.CompareTag("collect"))
        {
            Collect.instance.Collectable(other.gameObject);
            other.gameObject.GetComponent<BoxCollider>().isTrigger=false;
            other.gameObject.tag = "collected";
        }
    }
}

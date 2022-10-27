using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DestroyChild : MonoBehaviour
{
    //float yAxis;
    //GameObject backpack;

    void Start()
    {
        //backpack = GameObject.Find("carryPoint");
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("obstacle_2"))
        {
          foreach (Transform child in transform)
         {
             Destroy(child.gameObject);
             
         }
        }
        
        /*if(other.gameObject.CompareTag("collect"))
        {
            other.transform.localPosition = backpack.transform.position = new Vector3(0f, yAxis, 0f);
        }*/
        

        

    }
}

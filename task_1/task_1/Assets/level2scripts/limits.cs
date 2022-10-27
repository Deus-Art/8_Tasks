using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limits : MonoBehaviour
{
   float xMin=-9.5f , xMax=9.5f;
   Rigidbody rb;


    
    void Update()
    {
        Vector3 xPos = transform.position;
        xPos.x = Mathf.Clamp(xPos.x, xMin, xMax);
        transform.position=xPos;
        
        
    }
}

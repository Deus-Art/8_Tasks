using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizonLimit : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
             //store the transform.position of your car in a new Vector3, i called it "pos"
     Vector3 pos = transform.position;
     
     //then access the x value and clamp it
     pos.x = Mathf.Clamp (pos.x, -4, 4);
     
     //and don't forget to turn the new "pos" into the transform.position of your car
     transform.position = pos;
        
    }
}

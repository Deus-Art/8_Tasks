using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         transform.Rotate (Vector3.right * 100 * Time.deltaTime, Space.Self);
        //transform.Rotate( new Vector3(3f, 0, 0f) );
    }
}

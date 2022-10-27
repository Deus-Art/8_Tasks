using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zmove : MonoBehaviour
{

    public int moveSpeed=5;

    // Start is called before the first frame update
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        
    }
}

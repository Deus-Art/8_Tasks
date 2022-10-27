using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    float scale;
    public GameObject sketBig;
    void Update()
    {
        sketBig.transform.localScale = new Vector3 (transform.localScale.x + scale, transform.localScale.y + scale, transform.localScale.z + scale);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Collect"))
        {
            scale += 0.1f;
            other.GetComponent<BoxCollider>().enabled = false;
            other.GetComponent<MeshRenderer>().enabled = false;
            //sketBig.transform.position = new Vector3 (transform.position.x, 1f, transform.position.z);
            //Debug.Log("contact");
        }
    }
}

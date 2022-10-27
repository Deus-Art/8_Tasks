using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camfollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    // Update is called once per frame
    void LateUpdate()
    { 
        transform.position = target.position + offset;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limits : MonoBehaviour
{
    float limit = 4.5f;
    void Update()
    {
        transform.position = new Vector3 (Mathf.Clamp(transform.position.x, -limit, limit), transform.position.y, transform.position.z);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPosTwo : MonoBehaviour
{
    public float moveX =0.1f;
    Touch touching;
    void Update()
    {
        if(Input.touchCount > 0)
        {
            touching = Input.GetTouch(0);
            if(touching.phase == TouchPhase.Moved)
            {
                transform.localPosition = new Vector3(transform.localPosition.x + touching.deltaPosition.x * -moveX * Time.fixedDeltaTime,
                transform.localPosition.y,
                transform.localPosition.z);
            }
        }
        transform.position = new Vector3 (Mathf.Clamp(transform.position.x, 0f, 4.5f), transform.position.y, transform.position.z);
        
    }
}

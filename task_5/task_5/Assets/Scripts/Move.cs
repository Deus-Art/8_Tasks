using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    bool isMoving;
    public float speedZ = 10f;
    public float speedX = 0.1f;
    Touch touch;
    public float limitX = 5f;

    private void FixedUpdate() 
    {
        if(Input.GetMouseButton(0))
        {
            isMoving=true;
        }

        if(isMoving==true)
        {
            transform.parent.transform.position+=(Vector3.forward * speedZ * Time.fixedDeltaTime);
        }

        if(Input.touchCount>0)
        {
            touch = Input.GetTouch(0);
            if(touch.phase==TouchPhase.Moved)
            {
                transform.localPosition = new Vector3
                (
                    transform.localPosition.x + touch.deltaPosition.x * speedX * Time.fixedDeltaTime,
                    transform.localPosition.y,
                    transform.localPosition.z
                );
            }
        }

        transform.localPosition = new Vector3(Mathf.Clamp(transform.localPosition.x, -limitX, limitX), transform.localPosition.y, transform.localPosition.z);
    }
}

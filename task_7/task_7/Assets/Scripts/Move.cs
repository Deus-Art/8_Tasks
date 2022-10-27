using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    bool isMovin;
    //public float moveX = 0.1f;
    public float moveZ = 10f;
    //Touch touching;
    // private Vector3 mOffset;
    // private float mZCoord;

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            isMovin = true;
        }

        if(isMovin==true)
        {
            transform.position += (Vector3.forward * moveZ * Time.deltaTime);
        }    

        // if(Input.touchCount > 0)
        // {
        //     touching = Input.GetTouch(0);
        //     if(touching.phase == TouchPhase.Moved)
        //     {
        //         transform.localPosition = new Vector3(transform.localPosition.x + touching.deltaPosition.x * moveX * Time.fixedDeltaTime,
        //         transform.localPosition.y,
        //         transform.localPosition.z);
        //     }
        // }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Finish")){
            isMovin = false;
        }
    }

    //   void OnMouseDown()
    // {

    //     mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;



    //     // Store offset = gameobject world pos - mouse world pos

    //     mOffset = gameObject.transform.position - GetMouseAsWorldPoint();

    // }



    // private Vector3 GetMouseAsWorldPoint()
    // {

    //     // Pixel coordinates of mouse (x,y)

    //     Vector3 mousePoint = Input.mousePosition;



    //     // z coordinate of game object on screen

    //     mousePoint.z = mZCoord;



    //     // Convert it to world points

    //     return Camera.main.ScreenToWorldPoint(mousePoint);

    // }


    // void OnMouseDrag()

    // {

    //     transform.position = GetMouseAsWorldPoint() + mOffset;

    // }

}

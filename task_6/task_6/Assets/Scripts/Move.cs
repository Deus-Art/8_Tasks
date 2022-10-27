using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    bool isMovin;
    bool isFinish;
    public float speed = 10f;
    Touch touchie;
    public float xSpeed = 0.1f;
    float targetTransform;
    public GameObject win;

    void Start()
    {
        isMovin = false;
    }

    private void FixedUpdate() 
    {
        if(Input.GetMouseButton(0))
        {
            isMovin = true;
        }

        if(isMovin == true)
        {
            transform.parent.transform.position += (Vector3.forward * speed * Time.fixedDeltaTime);
            //transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
            //transform.position = new Vector3 (0f, transform.position.y, 5f) * Time.deltaTime;
            //transform.position += transform.forward * speed * Time.deltaTime;
        }


        if (isFinish && transform.position.z>=targetTransform)
        {
            isMovin=false;
            win.SetActive(true);
        }

        if(Input.touchCount > 0)
        {
            touchie = Input.GetTouch(0);
            if(touchie.phase == TouchPhase.Moved)
            {
                transform.localPosition = new Vector3(transform.localPosition.x + touchie.deltaPosition.x * xSpeed * Time.fixedDeltaTime,
                transform.localPosition.y,
                transform.localPosition.z);
            }
        }
        
         
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Finish")){
            targetTransform=transform.position.z+other.GetComponent<FinishLine>().collectFin.Count*1.5f;
            isFinish=true;
        }
    }
}

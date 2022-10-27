using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    bool isMoving;
    public float speed;
    Touch touch;
    public float xSpeed;
    public float limit = 4;
    public float limitY= 10f;
    /*public Text text;
    public float score;

    public GameObject[]collect;
    int cols;*/
    

    
    void FixedUpdate()
    {

        if(Input.GetMouseButtonDown(0))
          {
            isMoving=true;
          }
        if (isMoving==true)
          {
            
            transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
        
          }
          if(Input.touchCount>0)
          {
            touch = Input.GetTouch(0);
            if(touch.phase==TouchPhase.Moved){
                transform.position = new Vector3 (
                transform.position.x + touch.deltaPosition.x * xSpeed *Time.fixedDeltaTime,
                transform.position.y,
                transform.position.z);
            }
          }

          transform.position = new Vector3(Mathf.Clamp(transform.position.x, -limit, limit), Mathf.Clamp (transform.position.y,-limitY,limitY), transform.position.z);
          //text.text = "Score "+score.ToString();
    }

    /*private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("collect"))
        {
            score++;
        }
        
        if (other.gameObject.CompareTag("obstacle_1"))
        {
            score--;
        }

        if(other.gameObject.CompareTag("obstacle_2"))
        {
        Destroy(collect[cols]);
        }
    }*/
}

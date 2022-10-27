using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveZ : MonoBehaviour
{
    public float speed;
    public float xSpeed;
    public bool isMoving;
    Collider collide;
    Touch touch;
    public GameObject win;
    public GameObject lose;
    
    public Text text;
    public float score;

    public Material red;
    public Material normColor;
    
  
    void Start()
    {
        collide=GetComponent<Collider>();

    }

    
    void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0))
          {
            isMoving=true;
          }
        if (isMoving==true)
          {
            
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
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
          text.text="You Won Score "+score.ToString();
    }

    void OnTriggerEnter (Collider other)
    {
 
    if (other.gameObject.tag == "boost")
       {
         speed = 10;
         Invoke ("RegularSpeed", 2);
       }

    if(other.gameObject.tag == "invincible")
    {
        collide.enabled = false;
        transform.GetComponent<Renderer>().material = red;
        Invoke ("CollideOn" ,2);
    }

    if(other.gameObject.tag == "obstacle")
    {
            lose.SetActive(true);
            Time.timeScale=0;
    }
    if(other.gameObject.tag == "finishLine"){
            win.SetActive(true);
            Time.timeScale=0;
        }
    if(other.gameObject.CompareTag("Collectable")){
            score++;
        }
    }
    void RegularSpeed()
    {
        speed=5;

    }

    void CollideOn()
    {
        collide.enabled = true;
        transform.GetComponent<Renderer>().material = normColor;
    }

  

    
}

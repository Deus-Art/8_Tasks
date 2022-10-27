using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransParent : MonoBehaviour
{
    public Transform backpack;
    //public GameObject child;
    //private Text text;
    //private float score;

    void Update()
    {
        //text.text = "Score "+score.ToString();
    }
    private void OnTriggerEnter(Collider other) 
    {
     if(other.CompareTag("player"))
     {
      //backpack = other.transform;
      //backpack.parent = transform;
      transform.SetParent(backpack);
      transform.position = backpack.position;
      //score++;
     }   

     /*if (other.gameObject.CompareTag("obstacle_1"))
     {
        //score--;
     }

     if(other.gameObject.CompareTag("obstacle_2"))
     {
        //Destroy(this.gameObject);
     }*/
        
    }
}

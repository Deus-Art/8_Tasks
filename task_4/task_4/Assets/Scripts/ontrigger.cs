using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ontrigger : MonoBehaviour
{
    public Text text;
    public float score;
    public GameObject Win;
    public GameObject Lose;

    private void OnTriggerEnter(Collider other) 
    {

        if (other.gameObject.CompareTag("collect"))
        {
            score++;
            other.gameObject.GetComponent<SphereCollider>().isTrigger=false;
        }

         if (other.gameObject.CompareTag("obstacle_1"))
        {
            score--;
            other.gameObject.GetComponent<BoxCollider>().enabled=false;

            if(score<=0)
            {
                Lose.SetActive(true);
                Time.timeScale=0;
            }
        }

        if (other.gameObject.CompareTag("obstacle_2"))
        {   
            score=0;
            other.gameObject.GetComponent<BoxCollider>().enabled=false;
            
            if(score<0)
            {
                Lose.SetActive(true);
                Time.timeScale=0;
            }
        }

        if(other.gameObject.CompareTag("finish") && score>0)
        {
            Win.SetActive(true);
            text.text = "Score: "+score.ToString();
            Time.timeScale=0;
        }

        if(other.gameObject.CompareTag("finish") && score<=0)
        {
            Lose.SetActive(true);
            Time.timeScale=0;
        }
    }
}

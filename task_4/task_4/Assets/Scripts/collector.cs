using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class collector : MonoBehaviour
{
    GameObject backpack;
    float yAxis;
    public Text text;
    public float score;
    public GameObject Win;
    public GameObject Lose;

    //public GameObject[] collect;
    //int cols;
    void Start()
    {
        backpack = GameObject.Find("carryPoint");
        
    }

    void Update()
    {
        backpack.transform.localPosition = new Vector3 (0f, 0f, -0.7f);
        this.transform.localPosition = new Vector3 (0f, 0f, 0f);
        //text.text = "Score "+score.ToString();
    }

    
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("collect") && other.gameObject.GetComponent<collectables>().GetGotCollected()==false)
        {
            yAxis += 0.1f;
            other.gameObject.GetComponent<collectables>().MakeItCollected();
            other.gameObject.GetComponent<collectables>().OptIndex(yAxis);
            other.gameObject.transform.parent = backpack.transform;
            other.gameObject.transform.localPosition = backpack.transform.position = new Vector3(0f, yAxis, 0f);     
            score++;

        }
        
        if (other.gameObject.CompareTag("obstacle_1"))
        {
            score--;
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

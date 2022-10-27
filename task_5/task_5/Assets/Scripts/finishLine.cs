using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finishLine : MonoBehaviour
{
    public Text scoreText;
    public float score;
    public GameObject win;

   private void OnTriggerEnter(Collider other) 
   {
    if(other.gameObject.CompareTag("collected"))
    {
        score += 5;
        scoreText.text = "Score: "+score.ToString();
    }

    if(other.gameObject.CompareTag("sphere"))
    {
        score += 10;
        scoreText.text = "Score: "+score.ToString();
    }

    if(score>0)
    {
        win.SetActive(true);
    }

    if(other.gameObject.CompareTag("player"))
    {
        scoreText.text = "Score: "+score.ToString();
        Time.timeScale=0;
    }
    
   }
}

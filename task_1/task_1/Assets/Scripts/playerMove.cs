using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMove : MonoBehaviour
{
    bool gotCollected=true;
    public Text Score;
    public int uiPlus;

    bool gotcrash=true;

    public GameObject Win;
    public GameObject Lose;
    


    // Update is called once per frame
    void Update()
    {
        Score.text="Score "+uiPlus.ToString();
    }

    private void OnTriggerEnter(Collider other) {

         if(other.gameObject.CompareTag("Collectable")){
            uiPlus++;
        }

        if(other.gameObject.CompareTag("Obstacle"))
        {
            uiPlus--;
            Destroy(other.gameObject);

        }
        
        if(uiPlus==10){
            Win.SetActive(true);
            Time.timeScale=0;


        }

        if(uiPlus==-1){
            Lose.SetActive(true);
            Time.timeScale=0;
        }

        
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text text;
    public float score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text="Score: "+score;
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="red"){
            score++;
        }
        if(other.gameObject.tag=="green"){
            score++;
            score++;
            score++;
        }
        if(other.gameObject.tag=="blue"){
            score++;
            score++;
        }
    }
}

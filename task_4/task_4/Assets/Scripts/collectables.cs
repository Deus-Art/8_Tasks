using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectables : MonoBehaviour
{
    bool gotCollected;
    float index;
    public collector collector;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
          if(other.gameObject.CompareTag("obstacle_1"))
        {
            index--;
            transform.parent = null;
            GetComponent<SphereCollider>().enabled=false;
            other.gameObject.GetComponent<BoxCollider>().enabled=false;
        }

       /* if(other.gameObject.CompareTag("obstacle_2"))
        {
            Destroy(GetComponent<collectables>());
            transform.parent = null;
            GetComponent<SphereCollider>().enabled=false;
            //other.gameObject.GetComponent<BoxCollider>().enabled=false;
        }*/
        
    }

    public bool GetGotCollected()
    {
        return gotCollected;
    }

    public void MakeItCollected()
    {
        gotCollected=true;
    }

    public void OptIndex(float index)
    {
        this.index = index;
    }
}

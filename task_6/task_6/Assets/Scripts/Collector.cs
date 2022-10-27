using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public static Collector instance;

    public List<GameObject> collect = new List<GameObject>{};
    
    //public Transform parentPlayer;

    //public static Collect instance;
    //public static int counter;

    private void Awake() {
        if(!instance)
        {
            instance=this;

        }
    }


    private void Start() {
        //instance = this;
        //counter = 0;
        
    }
    private void FixedUpdate() 
    { 
        //Remove();
    }

    public void Collectable(GameObject obj)
    {
        obj.transform.parent=transform.parent.GetChild(1).transform;
        collect.Add(obj);
        collect[(collect.Count-1)].transform.position += new Vector3(0,0,collect.Count*1.5f);

        if(collect.Count==1)
        {obj.GetComponent<SmoothDamp>().SetLeadTransform(transform);}
        if(collect.Count>1)
        {obj.GetComponent<SmoothDamp>().SetLeadTransform(collect[(collect.Count-2)].transform);}

        /*Vector3 newPos = collect[count].transform.localPosition;
        newPos += new Vector3(0f , 0f, 3f);
        collect.Add(obj);
        obj.transform.localPosition=newPos;*/
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Collect"))
        {
            Collectable(other.gameObject);
            other.gameObject.GetComponent<BoxCollider>().isTrigger=false;
            other.gameObject.tag = "Collected";
        }

        // if(other.gameObject.CompareTag("Finish"))
        // {
        //     // for (int i = 0; i < collect.Count; i++)
        //     // {
        //     //     collect[(collect.Count-1)].transform.position += new Vector3(0, collect.Count*1f, 175);
        //     // }
        // }  
    }

    /*void Remove()
    {
        for (int i = 1; i < collect.Count; i++)
    {
        if(collect[i].CompareTag("remove"))
        {
            collect.Remove(collect[i]);
        }
    }

    }*/
}

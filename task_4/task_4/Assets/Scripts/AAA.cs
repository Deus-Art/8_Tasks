using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AAA : MonoBehaviour
{
    public List<GameObject> collectable = new List<GameObject> {};

    public Transform parentPlayer;

    private void Update() {
        for (int i = 1; i < collectable.Count; i++)
        {
            if (collectable[i].CompareTag("Destroy"))
            {
            collectable.Remove(collectable[i]);
            }
        }
    }
    public void Collectablee (GameObject obj, int count) 
    {
        obj.transform.parent=transform;
        Vector3 newPos = collectable[count].transform.localPosition;
        newPos += new Vector3 (0f, 0.1f, 0f);
        collectable.Add(obj);
        obj.transform.localPosition=newPos;
    }

    private void OnTriggerEnter(Collider other) 
    {

        if (other.gameObject.CompareTag("collect"))
        {
            Collectablee(other.gameObject, collectable.Count -1);
            other.gameObject.GetComponent<SphereCollider>().isTrigger=false;
        }

         if (other.gameObject.CompareTag("obstacle_1"))
        {
            collectable[collectable.Count-1].transform.parent = null;
            collectable[collectable.Count-1].tag = "Destroy";
        }

        if(other.gameObject.CompareTag("obstacle_2"))
        {
            other.gameObject.GetComponent<BoxCollider>().isTrigger=false;
           
           for (int i = collectable.Count-1; i > 0; i--)
           {
            collectable[i].transform.parent = null;
            collectable[i].tag = "Destroy";  
           }
        }

       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeToSphere : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    //public List<GameObject> finish = new List<GameObject> {};
    
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("shift"))
        {
            cube.GetComponent<MeshRenderer>().enabled = false;
            sphere.SetActive(true);    
        }

        if(other.gameObject.CompareTag("obs")) //when hits the obstacle destroying the collectables
        {
            cube.GetComponent<BoxCollider>().enabled=false;
            cube.GetComponent<MeshRenderer>().enabled = false;
            sphere.GetComponent<SphereCollider>().enabled = false;
            sphere.GetComponent<MeshRenderer>().enabled = false;
        }

        if(other.gameObject.CompareTag("finish"))
        {
          {
            //this.transform.parent = null;
            this.GetComponent<smoothDamp>().enabled=false;
            //this.transform.localPosition = other.transform.position;
            //this.transform.localPosition = new Vector3 (0f, 0.5f*2, 175f);
            //this.transform.parent = other.transform;
            //this.transform.localPosition = new Vector3 (0f, 0.5f*2f, 5f);
            
            /*this.transform.parent=transform;
            Vector3 newPos = finish[finish.Count].transform.localPosition;
            newPos += new Vector3 (0f, 0.5f, 0f);
            finish.Add(gameObject);
            this.transform.localPosition=newPos;*/
          }
        }
        
       
        
    }

}

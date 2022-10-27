using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    //public static Collector instance;
    public GameObject hamur;
    public Transform collectPoint;
    public List<GameObject> children = new List<GameObject>();
    //int childs;

    public float elapsedTime = 0;
    float maxDough = 5;
    public Image doughImage;
    //public Image bakeImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetChildren()
    {
        if(children.Count < maxDough)
         {
            GameObject go = Instantiate(hamur);    
            go.transform.parent = transform;
            children.Add(go);
            children[(children.Count - 1)].transform.localPosition = new Vector3(0, children.Count*0.05f, 0);
         }
        //  else
        //  {
        //     return;
        //  }

        // children.Capacity = children.Count;
        // children.Capacity = 5;
            // if(children.Count == 5)
            //     {
            //         maxDough = children.Capacity;
            //         return;
            //     }
            
    }

    

    private void OnTriggerStay(Collider other) {

        if(other.CompareTag("Hamur"))
        {
            
            elapsedTime += 0.02f;
            doughImage.fillAmount = elapsedTime;

            if(elapsedTime > 1)
            {
                elapsedTime = 0;
                GetChildren();
            } 
            else if(children.Count == maxDough)
            {
                elapsedTime -= 0.02f;
            }
        }

        if(other.CompareTag("GiveDough"))
        {
            // elapsedTime += 0.01f;
            // bakeImage.fillAmount = elapsedTime;
            int childs = transform.childCount;

                for (int i = childs - 1 ; i >= 0 ; i--)
                {
                    if(children.Count <= 5)
                    {
                        GameObject.Destroy(transform.GetChild(i).gameObject);
                        children.RemoveRange(0, children.Count);

                        if(children.Count == 0)
                        {
                            break;
                        }
                    }
                }
                
                // if(elapsedTime > 1)
                // {
                //     elapsedTime = 0;
                // }
        }
    }

    private void OnTriggerExit(Collider other) {
        
        if(other.CompareTag("Hamur"))
            {
                elapsedTime = 0;
                doughImage.fillAmount = elapsedTime;
            }

        // if(other.CompareTag("GiveDough"))
        //     {
        //         elapsedTime = 0;
        //         bakeImage.fillAmount = elapsedTime;
        //     }
        
    }
}

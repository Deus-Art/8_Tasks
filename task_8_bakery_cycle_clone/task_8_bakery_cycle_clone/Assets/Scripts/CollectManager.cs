using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectManager : MonoBehaviour
{
    public List<GameObject> doughList = new List<GameObject>();
    public GameObject doughPrefab;
    public Transform collectPoint;

    //public List<GameObject> breadListYo = new List<GameObject>();
    //public GameObject breadPrefabs;
    //public Transform collectPointBread;

    int doughLimit = 4;
    int fillLimit = 5;
    public float elapsedTime = 0;
    public Image fillingImage;
    //public Image bakingImage;

    //int breadLimitYo;
      
    private void OnEnable() 
    {

        TriggerManager.OnDoughCollect += GetDough;
        TriggerManager.OnDoughGive += GiveDough;
    
    }

    private void OnDisable() 
    {

        TriggerManager.OnDoughCollect -= GetDough;
        TriggerManager.OnDoughGive -= GiveDough;

    }

    void GetDough()
    {

        if(doughList.Count <= doughLimit){

            GameObject temp = Instantiate(doughPrefab, collectPoint);
            temp.transform.localPosition = new Vector3(2f, ((float)doughList.Count * 0.1f), 0f);
            temp.transform.localScale = new Vector3(3f,3f,3f);
            doughList.Add(temp);
            LeanTween.moveLocal(doughList[doughList.Count -1], new Vector3(0f, ((float)doughList.Count * 0.1f), 0f), 1f);
        }

    }

    void GiveDough()
    {
        if (doughList.Count > 0 )
        {
            
            TriggerManager.ovenManager.GetBread();
            RemoveLast();

        }

    }

    public void RemoveLast()
    {

        if(doughList.Count > 0)
        {   
            
            Destroy(doughList[doughList.Count - 1]);
            doughList.RemoveAt(doughList.Count - 1);
        }

    }

    private void OnTriggerEnter(Collider other) 
    {
        // if(other.CompareTag("GiveDough"))
        // {
        //      int childs = transform.childCount;

        //         for (int i = childs - 1 ; i >= 0 ; i--)
        //         {
        //             if(doughList.Count <= 5)
        //             {
        //                 GameObject.Destroy(transform.GetChild(i).gameObject);
                        

        //                 if(doughList.Count == 0)
        //                 {
        //                     break;
        //                 }
        //             }
        //         }
        // }
    }

  
    private void OnTriggerStay(Collider other) {
        
        if(other.CompareTag("fillONE"))
        {
            elapsedTime += 1f * Time.deltaTime ;
            fillingImage.fillAmount = elapsedTime;

                if(elapsedTime >= 1)
                {
                    elapsedTime = 0;  
                }

                else if(doughList.Count == fillLimit)
                {
                    elapsedTime = 0f;
                }
        }

        if(other.CompareTag("fillTWO"))
        {
            if (doughList.Count > 0 )
            {
            
                LeanTween.moveLocal(doughList[doughList.Count -1], new Vector3(2f, 1f, 1.5f), 1f);

            }
            
        }
        // if(other.CompareTag("GiveDough"))
        // {
        //      int childs = transform.childCount;

        //         for (int i = childs - 1 ; i >= 0 ; i--)
        //         {
        //             if(doughList.Count <= 5)
        //             {
        //                 GameObject.Destroy(transform.GetChild(i).gameObject);
                        

        //                 if(doughList.Count == 0)
        //                 {
        //                     break;
        //                 }
        //             }
        //         }
        // }

        // if(other.CompareTag("fillTWO"))
        // {
        //     elapsedTime += 0.015f;
        //     bakingImage.fillAmount = elapsedTime;
            
        //         if(elapsedTime > 1)
        //         {   
        //             elapsedTime = 0;                
        //         }

        //         else if(doughList.Count == secondFillLimit)
        //         {
        //             elapsedTime = 0f;
        //         } 
        // }
    }

    // private void OnTriggerExit(Collider other) 
    // {
    //     if(other.CompareTag("GiveDough"))
    //     {
    //         doughPrefab.GetComponent<SkinnedMeshRenderer>().enabled = true;
    //     }
    // }

    private void OnTriggerExit(Collider other) {
        // if(other.CompareTag("GiveDough"))
        // {
        //      int childs = transform.childCount;

        //         for (int i = childs - 1 ; i >= 0 ; i--)
        //         {
        //             if(doughList.Count <= 5)
        //             {
        //                 GameObject.Destroy(transform.GetChild(i).gameObject);
                        

        //                 if(doughList.Count == 0)
        //                 {
        //                     break;
        //                 }
        //             }
        //         }
        // }

        if(other.CompareTag("fillONE"))
        {
            elapsedTime = 0 ;
            fillingImage.fillAmount = elapsedTime;

                
        }
    }
}

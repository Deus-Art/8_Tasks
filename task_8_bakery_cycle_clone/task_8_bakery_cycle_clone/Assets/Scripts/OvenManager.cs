using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OvenManager : MonoBehaviour
{
    public List<GameObject> breadList = new List<GameObject>();
    public Transform breadTransform;
    public GameObject breadPrefab;

    public float elapsedTime = 0;
    public Image bakingImage;
    int secondFillLimit = 5;


    private void OnEnable() 
    {
        TriggerManager.OnBreadCollect += GiveBread;
    }

    private void OnDisable() 
    {
        TriggerManager.OnBreadCollect -= GiveBread;
    }

    public void GetBread()
    {
        GameObject temp = Instantiate(breadPrefab, breadTransform);
        temp.transform.localPosition = new Vector3(0f, 0f, breadList.Count * 1f);
        breadList.Add(temp);
    }

    void GiveBread()
    {
        if (breadList.Count > 0 )
        {

            TriggerManager.collectManBread.SndGetBread();
            RemoveLast();

        }

    }

    public void RemoveLast()
    {

        if(breadList.Count > 0){

            Destroy(breadList[breadList.Count - 1]);
            breadList.RemoveAt(breadList.Count - 1);
        }

    }

    private void OnTriggerStay(Collider other) {
        
        if(other.CompareTag("Player"))
        {
            elapsedTime += 0.5f * Time.deltaTime;
            bakingImage.fillAmount = elapsedTime;
            
                if(elapsedTime >= 1)
                {   
                    elapsedTime = 0;                
                }

                else if(breadList.Count == secondFillLimit)
                {
                    elapsedTime = 0f;
                } 
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player"))
        {
            elapsedTime = 0f;
            bakingImage.fillAmount = elapsedTime;

                
    }
    }
 
}

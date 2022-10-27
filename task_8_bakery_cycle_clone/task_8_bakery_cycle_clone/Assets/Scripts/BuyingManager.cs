using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyingManager : MonoBehaviour
{
    public List<GameObject> buyingList = new List<GameObject>();
    public GameObject breadBought;
    public Transform pointOfBought;
    
   private void OnEnable() 
   {
        TriggerManager.OnBuyingBread += SellingGetBreads;
   }

   private void OnDisable() 
   {
        TriggerManager.OnBuyingBread -= SellingGetBreads;
   }

   public void SellingGetBreads()
    {
            GameObject temp = Instantiate(breadBought, pointOfBought);
            temp.transform.localPosition = new Vector3(0f, 0f, ((float)buyingList.Count * 0.5f));
            temp.transform.localScale = new Vector3(5f, 3f, 2f);
            buyingList.Add(temp);
        

    }

    void BoughtBread()
    {
        if (buyingList.Count > 0 )
        {

           // TriggerManager.sellingManager.GiveBread();
            RemoveLast();

        }

    }

    public void RemoveLast()
    {

        if(buyingList.Count > 0){

            Destroy(buyingList[buyingList.Count - 1]);
            buyingList.RemoveAt(buyingList.Count - 1);
        }

    }
}

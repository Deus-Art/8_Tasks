using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerManager : MonoBehaviour
{
    public delegate void OnCollectArea();
    public static event OnCollectArea OnDoughCollect;


    public delegate void OnSndBread();
    public static event OnSndBread OnBreadCollect;


    public delegate void OnOwenArea();
    public static event OnOwenArea OnDoughGive;


    public delegate void OnDeliverArea();
    public static event OnDeliverArea OnBreadGive;


    public delegate void OnBuyingArea();
    public static event OnBuyingArea OnBuyingBread;


    public static OvenManager ovenManager;
    public static CollectManBread collectManBread;
    public static SellingManager sellingManager;
    public static CollectManager collectManager;
    public static BuyingManager buyingManager;
    

    bool isCollecting, isGiving, isReceiving, isSelling, theyAreBuying;

    private void Start() 
    {
        StartCoroutine(CollectEnum());
        StartCoroutine(CollectEnumTwo());
        StartCoroutine(CollectEnumThree());
        
    }

    IEnumerator CollectEnum()
    {
        
        while(true)
        {

            if(isCollecting == true)
            {       
                OnDoughCollect();
            }

           

            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator CollectEnumTwo()
    {
        while(true)
        {

            if(isGiving == true)
            {
                OnDoughGive();
            }

            // if(theyAreBuying == true)
            // {
            //     OnBuyingBread();
            // }

            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator CollectEnumThree()
    {
        while(true)
        {
             if(isReceiving == true)
            {
                OnBreadCollect();
            }

            if(isSelling == true)
            {
                OnBreadGive();
            }

            yield return new WaitForSeconds(0f);
        }
    }
    private void OnTriggerStay(Collider other) 
    {    

        if(other.CompareTag("Hamur"))
        {
            isCollecting = true;  
        }

         

        

    }
    
    private void OnTriggerExit(Collider other)
    {

        if(other.CompareTag("Hamur"))
        {
            isCollecting = false;
        }

        if(other.CompareTag("GiveDough"))
        {
            isGiving = true;
            //ovenManager = null;
        }

        // if(other.CompareTag("DONTGIVEDOUGH"))
        // {
        //     isGiving = false;
        // }

        if(other.CompareTag("TakeBread"))
        {
            isReceiving = true;
        }

        if(other.CompareTag("SellingPoint"))
        {
            isSelling = false;
        }

        // if(other.CompareTag("BuyingZone"))
        // {
        //     theyAreBuying = true;
        //     //buyingManager = other.GetComponent<BuyingManager>();
        // }

    }

    private void OnTriggerEnter(Collider other) 
    {

        if(other.CompareTag("TakeBread"))
        {
            isReceiving = true;
            collectManBread = other.GetComponent<CollectManBread>();
        }

        if(other.CompareTag("SellingPoint"))
        {
            isSelling = true;
            isReceiving = false;
            sellingManager = other.GetComponent<SellingManager>();
        }
        // if(other.CompareTag("BuyingZone"))
        // {
        //     theyAreBuying = true;
        //     //buyingManager = other.GetComponent<BuyingManager>();
        // }

        if(other.CompareTag("GiveDough"))
        {
            isGiving = true;
            ovenManager = other.GetComponent<OvenManager>();
        }
    }

}

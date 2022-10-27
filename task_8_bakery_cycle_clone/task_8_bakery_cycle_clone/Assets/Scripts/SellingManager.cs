using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SellingManager : MonoBehaviour
{
    public List<GameObject> sellingList = new List<GameObject>();
    public GameObject sellBreadPrefab;
    public Transform sellingPoints;

    public List<GameObject> charList = new List<GameObject>();
    public GameObject charComing;
    public Transform charComingPoint;

    public float moneyCount = 5;
    //public Image moneyImage;
    public TextMeshProUGUI moneyText;


    private void Start() {
        StartCoroutine(DestroyBreads());
    }
    private void OnEnable() 
    {
        //TriggerManager.OnBreadGive += SellingGetBread;
    }

    private void OnDisable() 
    {
        //TriggerManager.OnBreadGive -= SellingGetBread;
    }

    public void SellingGetBread()
    {
            GameObject temp = Instantiate(sellBreadPrefab, sellingPoints);
            temp.transform.localPosition = new Vector3(0f, 0f, ((float)sellingList.Count * 0.5f));
            temp.transform.localScale = new Vector3(5f, 3f, 2f);
            sellingList.Add(temp);

            GameObject tempo = Instantiate(charComing, charComingPoint);
            tempo.transform.localPosition = new Vector3(charList.Count * 1f, 0f, 0f);
            tempo.transform.localScale = new Vector3(1f, 1f, 1f);
            charList.Add(tempo);
    }

    IEnumerator DestroyBreads(){
        while(true)
        {
            // if(sellingList.Count >= 0)
            // {
            // int childs = transform.childCount;

            //     for (int i = childs - 1 ; i >= 0 ; i--)
            //     {
            //         if(sellingList.Count <= 5)
            //         {
            //             GameObject.Destroy(transform.GetChild(i).gameObject);
            //             sellingList.RemoveRange(0, sellingList.Count);

            //             if(sellingList.Count == 0)
            //             {
            //                 break;
            //             }
            //         }
            //     }
            //     }
                
                RemoveLast();
                yield return new WaitForSeconds (2f);
        }
    }

    // public void GiveBread()
    // {
    //     if (sellingList.Count > 0 )
    //     {

    //         TriggerManager.buyingManager.SellingGetBreads();
    //         RemoveLast();

    //     }

    // }

    public void RemoveLast()
    {

        if(sellingList.Count > 0){

            Destroy(sellingList[sellingList.Count - 1]);
            sellingList.RemoveAt(sellingList.Count - 1);
            Destroy(charList[charList.Count - 1]);
            charList.RemoveAt(charList.Count - 1);
            moneyCount += 5;
            moneyText.text = " " +moneyCount.ToString();
        }

    }


}

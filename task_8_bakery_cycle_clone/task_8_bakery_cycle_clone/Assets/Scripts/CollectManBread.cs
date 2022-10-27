using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectManBread : MonoBehaviour
{
    public List<GameObject> sndBreadList = new List<GameObject>();
    public GameObject sndBreadPrefab;
    public Transform collectPoint;
    OvenManager ovenManager;

    int sndBreadLimit = 4;

    private void OnEnable() 
    {

        //TriggerManager.OnBreadCollect += SndGetBread;
        TriggerManager.OnBreadGive += SndGiveBread;
    
    }

    private void OnDisable() 
    {

        //TriggerManager.OnBreadCollect -= SndGetBread;
        TriggerManager.OnBreadGive -= SndGiveBread;

    }

    public void SndGetBread()
    {
            GameObject temp = Instantiate(sndBreadPrefab, collectPoint);
            temp.transform.localPosition = new Vector3(0f, ((float)sndBreadList.Count * 0.1f), 0f);
            temp.transform.localScale = new Vector3(2.5f, 1.5f, 1f);
            sndBreadList.Add(temp);
    }

    void SndGiveBread()
    {
        if (sndBreadList.Count > 0 )
        {

            TriggerManager.sellingManager.SellingGetBread();
            RemoveLast();

        }

    }

    public void RemoveLast()
    {

        if(sndBreadList.Count > 0){

            Destroy(sndBreadList[sndBreadList.Count - 1]);
            sndBreadList.RemoveAt(sndBreadList.Count - 1);
        }

    }
}

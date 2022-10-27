using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BakedOrders : MonoBehaviour
{
    public GameObject bread;
    public List<GameObject> readyBreads = new List<GameObject>();
    float maxBreads = 5;
    float elapsedTime = 0;
    public Image bakeImage;
    
    public void BakedBread()
    {
        if(readyBreads.Count <= maxBreads)
        {
            GameObject bake = Instantiate(bread);
            bake.transform.parent = transform;
            readyBreads.Add(bake);
            readyBreads[(readyBreads.Count - 1)].transform.localPosition = new Vector3(0f, 0f, readyBreads.Count * 0.7f);
        }
    }

    private void OnTriggerStay(Collider other) {
        if(other.CompareTag("Player"))
        {
            elapsedTime += 0.01f;
            bakeImage.fillAmount = elapsedTime;
        }

        if(elapsedTime > 1)
        {
            elapsedTime = 0;
            BakedBread();
        }
        else if(readyBreads.Count == maxBreads)
        {
            elapsedTime -= 0.01f;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player"))
        {
            elapsedTime = 0f;
            bakeImage.fillAmount = elapsedTime;
        }
    }
}

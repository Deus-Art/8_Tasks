using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GateTrigger : MonoBehaviour
{
    public GameObject lose;
    public float count;
    public TextMeshProUGUI countText;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            lose.SetActive(true);
            Time.timeScale = 0;
        }

        if(other.gameObject.CompareTag("Collected"))
        {
            count++;
            countText.text = " "+count.ToString();
            Destroy(other.gameObject);
        }
    }
}

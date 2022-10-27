using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishLine : MonoBehaviour
{
    public GameObject win;
    //public GameObject player;
    //public TextMeshProUGUI textMPro;
    //public float score;
    public List<GameObject> collectFin = new List<GameObject>{};
    
    private void Update() {
        
        // foreach (var gameObject in collectFin)
        // {
        //     player.transform.Translate(Vector3.forward);
        // }
    }

    public void Collectable(GameObject obj)
    {
        obj.transform.parent=transform.parent.GetChild(0).transform;
        collectFin.Add(obj);
        //collectFin[(collectFin.Count-1)].transform.position += new Vector3(0,0,collectFin.Count*1.5f);
        //player.transform.position += new Vector3 (0f,0f,collectFin.Count);
    }
    
    private void OnTriggerEnter(Collider other) {
        // if(other.gameObject.CompareTag("Collected")){
        //     score++;
        //     textMPro.text = "0 "+score.ToString();
        //     Destroy(other.gameObject);
        // }

        if(other.gameObject.CompareTag("Collected"))
        {
            Collectable(other.gameObject);
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }

        // if(other.gameObject.CompareTag("Player"))
        // {
        //     //Time.timeScale = collectFin.Count;
        //     Invoke("StopGame", collectFin.Count);
        // }
    }

    // public void StopGame(){
    //     Time.timeScale = 0;
    //     win.SetActive(true);
    // }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MeshOff : MonoBehaviour
{
    public GameObject skeGreen;
    public GameObject skeGreen2;
    public GameObject skeRed;
    public GameObject skeRed2;
    public GameObject skeBig;
    void Update()
    {
        if(skeGreen.transform.position.x == 0 && skeRed.transform.position.x == 0)
        {
            skeGreen.GetComponent<SkinnedMeshRenderer>().enabled = false;
            skeGreen.GetComponent<BoxCollider>().enabled = false;
            skeRed.GetComponent<SkinnedMeshRenderer>().enabled = false;
            skeRed.GetComponent<BoxCollider>().enabled = false;
            skeBig.GetComponent<SkinnedMeshRenderer>().enabled = true;
            skeBig.GetComponent<BoxCollider>().enabled = true;

        }
        if(skeGreen.transform.position.x <= -0.1f && skeRed.transform.position.x >= 0.1)
        {
            skeGreen.GetComponent<SkinnedMeshRenderer>().enabled = true;
            skeGreen.GetComponent<BoxCollider>().enabled = true;
            skeRed.GetComponent<SkinnedMeshRenderer>().enabled = true;
            skeRed.GetComponent<BoxCollider>().enabled = true;
            skeBig.GetComponent<SkinnedMeshRenderer>().enabled = false;
            skeBig.GetComponent<BoxCollider>().enabled = false;

        }
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Finish")){
             //transform.position = new Vector3(Mathf.Lerp(this.transform.position.x, 0f, 1f), transform.position.y, transform.position.z);
            // Debug.Log("hi");\
            skeGreen2.transform.DOMoveX(0f, 1f);
            skeRed2.transform.DOMoveX(0f, 1f);
        }
    }
}

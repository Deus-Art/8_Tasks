using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ComeTogether : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Finish")){
             //transform.position = new Vector3(Mathf.Lerp(this.transform.position.x, 0f, 1f), transform.position.y, transform.position.z);
            // Debug.Log("hi");\
            transform.DOMoveX(0f, 1f);
        }
    }
}

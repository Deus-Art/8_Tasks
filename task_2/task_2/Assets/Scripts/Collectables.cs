using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Collectables : MonoBehaviour
{
    public Material[] mat;
    Renderer rend;

    private void Start() {
        rend=GetComponent<Renderer>();
        rend.enabled=true;
        rend.sharedMaterial=mat[0];
    }
    private void OnTriggerEnter(Collider collision) {
        if(collision.gameObject.tag=="red"){
            rend.sharedMaterial=mat[1];
            Destroy(collision.gameObject);

        }
        if(collision.gameObject.tag=="green"){
            rend.sharedMaterial=mat[2];
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag=="blue"){
            rend.sharedMaterial=mat[3];
            Destroy(collision.gameObject);
        }
    }
}

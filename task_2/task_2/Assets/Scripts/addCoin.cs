using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addCoin : MonoBehaviour
{

    public float limits = 35f;
    // Start is called before the first frame update
    void Start()
    {

        AddCoin();

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

       private void AddCoin()
    {
        var coinPosition = new Vector3(Random.Range(-limits, limits), gameObject.transform.position.y, Random.Range(-limits, limits));
        //Instantiate(gameObject, coinPosition, gameObject.transform.rotation);
        gameObject.transform.position = coinPosition;
    }

    private void OnTriggerEnter(Collider collision) {

         if(collision.gameObject.tag=="Player"){
        var coinPosition = new Vector3(Random.Range(-limits, limits), gameObject.transform.position.y, Random.Range(-limits, limits));
        Instantiate(gameObject, coinPosition, gameObject.transform.rotation);
        }
        
    }
}

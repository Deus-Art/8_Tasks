using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vecMoveTow : MonoBehaviour
{
   public Transform[] targets;

    int targs;

    public float speed = 10f;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targets[targs].position, speed*Time.deltaTime);
        if(Vector3.Distance(transform.position, targets[targs].position)<0.1f)
        {
            targs++;
            if(targs>=targets.Length)
            {
                targs=0;
            }
        }
    }
}

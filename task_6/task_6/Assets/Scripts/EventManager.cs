using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    public static event Action EventMnger;
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            // if(EventMnger != null)
            // {
            //     EventMnger();
            // }
            EventMnger?.Invoke();
        }
        
    }
}

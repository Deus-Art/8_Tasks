using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class XPosOne : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    // public float moveX = 0.1f;
    // Touch touching;
    // void Update()
    // {
    //     if(Input.touchCount > 0)
    //     {
    //         touching = Input.GetTouch(0);
    //         if(touching.phase == TouchPhase.Moved)
    //         {
    //             transform.localPosition = new Vector3(transform.localPosition.x + touching.deltaPosition.x * moveX * Time.fixedDeltaTime,
    //             transform.localPosition.y,
    //             transform.localPosition.z);
    //         }
    //     }
    //     transform.position = new Vector3 (Mathf.Clamp(transform.position.x, -4.5f, 0f), transform.position.y, transform.position.z);
        
    // }

    private Vector3 position;
    private float timeCount = 0.0f;

    public void OnBeginDrag(PointerEventData eventData)
    {
        position = transform.position;
        Debug.Log("OnBeginDrag: " + position);
    }

    // Drag the selected item.
    public void OnDrag(PointerEventData data)
    {
        if (data.dragging)
        {
            // Object is being dragged.
            timeCount += Time.deltaTime;
            if (timeCount > 0.25f)
            {
                Debug.Log("Dragging:" + data.position);
                timeCount = 0.0f;
            }
        }
        transform.position = data.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = position;
        Debug.Log("OnEndDrag: " + position);
    }
}

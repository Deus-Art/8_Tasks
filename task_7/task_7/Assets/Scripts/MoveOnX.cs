using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class MoveOnX : MonoBehaviour, IDragHandler, IBeginDragHandler //IEndDragHandler

{
     float moveX = 0.02f;
    public GameObject gGreen;
    public GameObject gRed;
    
    public void OnBeginDrag( PointerEventData eventData )
    {
       
        Debug.Log( "Dokunan parmak hareket etmeye başladı: " + eventData.pointerId + " " + eventData.position );
    }
 
    public void OnDrag( PointerEventData eventData )
    {
       
        Vector3 gTrans=gGreen.transform.position;
        gTrans.x = Mathf.Clamp(gTrans.x + eventData.delta.x * -moveX, -5, 0);
        gGreen.transform.position = gTrans;

        Vector3 rTrans=gRed.transform.position;
        rTrans.x = Mathf.Clamp(rTrans.x + eventData.delta.x * moveX, 0, 5);
        gRed.transform.position = rTrans;

        
        
        
        Debug.Log( "Parmak hareket ediyor: " + eventData.delta.x );
    }
 
    // public void OnEndDrag( PointerEventData eventData )
    // {
    //     Debug.Log( "Parmak dokunmayı kesti: " + eventData.pointerId + " " + eventData.position );
    // }
 
   
}

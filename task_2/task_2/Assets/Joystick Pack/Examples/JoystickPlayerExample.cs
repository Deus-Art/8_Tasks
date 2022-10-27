using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public FixedJoystick variableJoystick;
    

    

    //[SerializeField] private float rollSpeed = 3;
    //private bool ismoving;

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        //rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        
        transform.position += direction * speed* Time.deltaTime;
        transform.LookAt(direction*speed*Time.deltaTime);
    
        
        //transform.Translate(transform.forward, Space.World);
        //transform.Translate(Vector3.forward * Time.deltaTime, Space.Self);
        //transform.position += transform.right * speed * 0.06f;
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //transform.position = Vector3.forward * speed;
        //rb.transform.Translate(Vector3.right * variableJoystick.Horizontal * speed);
        //rb.transform.Translate(Vector3.forward * variableJoystick.Vertical * speed *Time.deltaTime);
        //rb.transform.Rotate(0,0,5);
        //if(ismoving) return;
        //if(variableJoystick){
            //var anchor = transform.position = new Vector3(0.5f,0.5f,0 );
           // var axis = Vector3.Cross(Vector3.up, Vector3.left);
           // StartCoroutine(Roll(anchor,axis));
        //}
        //IEnumerator Roll(Vector3 anchor, Vector3 axis){
            //ismoving=true;
           // for (int i = 0; i < (90 / rollSpeed); i++)
           // {
              //  transform.RotateAround(anchor, axis, rollSpeed);
               // yield return new WaitForSeconds(0.01f);
                
           // }
           //ismoving=false;
        //}


    }
}
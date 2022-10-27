using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class jump : MonoBehaviour
{
    public Vector3 jumps;
    public float jumpForce = 2.0f;
     
    public bool isGrounded = true;
    Rigidbody rb;

private void Start() {
    rb = GetComponent<Rigidbody>();
    jumps = new Vector3(0.0f, 2.0f, 0.0f);

}

void OnCollisionStay()
         {
             isGrounded = true;
         }
    
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.A) && isGrounded){
     
            rb.AddForce(jumps * jumpForce, ForceMode.Impulse);
            isGrounded = false;
             }

        
    }
}

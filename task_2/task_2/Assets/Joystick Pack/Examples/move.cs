using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public FixedJoystick fj;

    public float rotateSpeed;
    public float moveSpeed;
    public float childRotateSpeed;
    public GameObject child;

    private void Update() {
        var x = fj.Horizontal;
        var y = fj.Vertical;

        Vector3 direction = Vector3.forward *fj.Vertical + Vector3.right * fj.Horizontal;
        transform.LookAt(direction*100f);
        if(direction.magnitude>=0.1f){
            transform.position += direction*moveSpeed*Time.deltaTime;
            child.transform.Rotate(Vector3.right*Time.deltaTime*childRotateSpeed);
        }
        transform.Rotate(new Vector3(0, x* Time.deltaTime * rotateSpeed, 0));

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystickLevel2 : MonoBehaviour
{
    public float speed;
    public FixedJoystick variableJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.right * variableJoystick.Horizontal;
        rb.transform.Translate(direction * speed * Time.fixedDeltaTime);
    }
}

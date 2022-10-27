using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Path : MonoBehaviour
{
    public PathCreator pathCreator;

    public float speed = 5;
    float distanceTravelled;
    bool isMoving;
    private Animator animator;

    private void Start() {
        animator = GetComponent<Animator>();
    }

    private void Update() {

        if(Input.GetMouseButtonDown(0)){
            isMoving = true;
        }
        else if (Input.GetMouseButtonUp(0)){
            isMoving = false;
        }
        
        if(isMoving==true)
        {
            animator.SetBool("ismoving", true);
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        } 
        else {
            animator.SetBool("ismoving", false);
        } 
    }

    // private void OnMouseDown() {
    //     isMoving = true;
    //     Debug.Log("down");
    // }

    // private void OnMouseExit() {
    //     isMoving = false;
    //     Debug.Log("exit");
    // }

   
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 mousePosition;
    Vector3 initialPosition;
    private bool wasTheBallReleased = false;


    Animator animator;

    void Start()
    {
        initialPosition = transform.position;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Release();
        Whereto();
    }

    private void Whereto() 
    {

        if (!wasTheBallReleased)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 40));
            transform.position = new Vector3(mousePosition.x, initialPosition.y, initialPosition.z);

        }
    }

    private void Release() 
    {
        if (Input.GetMouseButtonUp(0)) 
        {   wasTheBallReleased=true;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;   
        }    
    }

    private void OnDestroy()
    {
        animator.SetTrigger("Destroy");
    }
}

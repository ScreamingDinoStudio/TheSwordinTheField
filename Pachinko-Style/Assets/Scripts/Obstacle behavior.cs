using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclebehavior : MonoBehaviour
{

    [Header("Movement Behavior")]

    private Vector3 initialPosition;
    private Vector3 finalPosition;
    private Vector3 currentPosition;
    private Vector3 targetPosition;
    public bool reachedPosition = false;
    [SerializeField] float maxDistRangeInX = 1f;
    [SerializeField] float maxDistanceRangeInY = 0f;
    private float distInX, distInY;

    [Header("Movement Speed")]
    private float speed = 2f;
    [SerializeField] float minimumSpeed = 2f;
    [SerializeField] float maximumSpeed = 3f;

    [Header("Rotation Behavior")]
    public Vector3 changeRotation;

    void Start()
    {
       initialPosition = transform.position;
       currentPosition = transform.position;
       SetRandomValues();  
    }


    void Update()
    {
        Oscilation();
        transform.Rotate(changeRotation);
    }

    //Set the random values for the objects
        private void SetRandomValues() 
    { 
        distInX = Random.Range(-maxDistRangeInX,maxDistRangeInX);
        distInY = Random.Range(-maxDistanceRangeInY, maxDistanceRangeInY);
        finalPosition.x = initialPosition.x + distInX;
        finalPosition.y = initialPosition.y + distInY;
        targetPosition = finalPosition;

        speed = Random.Range(minimumSpeed, maximumSpeed);
    }

    //Make the object move in x and y
        private void Oscilation()
    {
        if (currentPosition == targetPosition && !reachedPosition)
        {
                targetPosition = initialPosition; 
                reachedPosition = true; 
        }
        
        if (currentPosition == targetPosition && reachedPosition)
        { 
                targetPosition = finalPosition; 
                reachedPosition = false; 
        } 
        currentPosition = Vector3.MoveTowards(currentPosition, targetPosition, speed * Time.deltaTime);
        transform.position = currentPosition;
    }
}

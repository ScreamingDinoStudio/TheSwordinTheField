using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject sword;
    private Vector3 spawnPoint;

    void Start()
    {
        spawnPoint = transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        SwordSpawn();
    }

    private void SwordSpawn() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(sword).transform.position = spawnPoint;
        }
    
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameTrigger : MonoBehaviour
{
    [SerializeField] GameObject videoPlayer;
    [SerializeField] GameObject Canvas;
    [SerializeField] GameObject EndGameCinematic;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EndGameCinematic.SetActive(true);
    }

}

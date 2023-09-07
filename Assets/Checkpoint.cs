using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    Transform checkPoint;
    GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        checkPoint = this.transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Access the PlayerMove component
            PlayerMove playerMove = player.GetComponent<PlayerMove>();

            // Update the checkpoint positions in the PlayerMove component
            playerMove.inicioX = checkPoint.position.x;
            playerMove.inicioY = checkPoint.position.y;

            // Disable the checkpoint game object
            gameObject.SetActive(false);
        }
    }
}

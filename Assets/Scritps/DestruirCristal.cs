using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirCristal : MonoBehaviour
{
    public OpenDoor openDoorScript; // Referencia al script OpenDoor

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject); // Destruir el cristal
            if (openDoorScript != null)
            {
                openDoorScript.cristalActivo = false; // Desactivar el cristal en el script OpenDoor
            }
        }
    }
}

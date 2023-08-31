using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    Animator openDoor;
    [SerializeField] GameObject cristal;
    public bool cristalActivo;

    private void Start()
    {
        openDoor = GetComponent<Animator>();
        cristalActivo = true;
    }

    private void Update()
    {
        if (!cristalActivo)
        {
            openDoor.SetTrigger("Abrir");
        }
    }
}

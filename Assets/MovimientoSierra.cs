using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSierra : MonoBehaviour
{
    public Transform puntoA;
    public Transform puntoB;
    public float velocidad;

    private bool haciaPuntoB = true;

    // Update is called once per frame
    void Update()
    {
        
        Vector3 direccion = haciaPuntoB ? (puntoB.position - transform.position) : (puntoA.position - transform.position);

        direccion.Normalize();

        float desplazamiento = velocidad * Time.deltaTime;

        if ((transform.position - puntoA.position).sqrMagnitude < desplazamiento * desplazamiento)
        {
            haciaPuntoB = true;
        }
        else if ((transform.position - puntoB.position).sqrMagnitude < desplazamiento * desplazamiento)
        {
            haciaPuntoB = false;
        }
        transform.Translate(direccion * desplazamiento);
    }
}


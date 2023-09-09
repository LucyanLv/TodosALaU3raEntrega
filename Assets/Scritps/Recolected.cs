using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Recolected : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI InicioCanvas;
    
    [Header("Barriles")]
    [SerializeField] GameObject[] barriles;
    private int barrilesDestruidos = 0;
    [SerializeField] GameObject colliderBarriles;
    [SerializeField] TextMeshProUGUI aguaCanvas;

    [Header("Llantas")]
    [SerializeField] GameObject[] extintores;
    private int extintoresDestruidos = 0;
    [SerializeField] GameObject colliderLlantas;
    [SerializeField] TextMeshProUGUI llantasCanvas;
    [SerializeField] GameObject fuegoParticulasLlantas;

    [Header("Smog")]
    [SerializeField] GameObject[] regaderas;
    private int regaderasDestruidos = 0;
    [SerializeField] GameObject colliderRegaderas;
    [SerializeField] TextMeshProUGUI regaderasCanvas;
    [SerializeField] GameObject smogParticulas;

    [Header("incendio")]
    [SerializeField] GameObject[] extintores2;
    private int extintores2Destruidos = 0;
    [SerializeField] GameObject colliderExtintores2;
    [SerializeField] TextMeshProUGUI IncendioCanvas;
    [SerializeField] GameObject IncendioParticulas;
    private void Start()
    {
        StartCoroutine(FirstCanvas());
        //Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BarrilColectable"))
        {
            Destroy(other.gameObject); // Destruir el barril que el jugador tocó
            barrilesDestruidos++;

            if (barrilesDestruidos >= barriles.Length)
            {
                // Todos los barriles han sido destruidos
                Destroy(colliderBarriles); // Destruir el objeto colliderBarriles
                if (aguaCanvas != null)
                {
                    aguaCanvas.gameObject.SetActive(true); // Activar el canvas TextMeshPro
                    StartCoroutine(DesactivarAguaCanvas());
                }
            }
        }

        if (other.CompareTag("Extintores1Colectable"))
        {
            Destroy(other.gameObject); // Destruir el barril que el jugador tocó
            extintoresDestruidos++;

            if (extintoresDestruidos >= extintores.Length)
            {
                // Todos los barriles han sido destruidos
                Destroy(colliderLlantas); // Destruir el objeto colliderBarriles
                if (llantasCanvas!= null)
                {
                    llantasCanvas.gameObject.SetActive(true); // Activar el canvas TextMeshPro
                    StartCoroutine(DesactivarFuegoCanvas());
                    fuegoParticulasLlantas.SetActive(false);
                }
            }
        }

        if (other.CompareTag("RegaderasColectable"))
        {
            Destroy(other.gameObject); // Destruir el barril que el jugador tocó
            regaderasDestruidos++;

            if (regaderasDestruidos >= regaderas.Length)
            {
                // Todos los barriles han sido destruidos
                Destroy(colliderRegaderas); // Destruir el objeto colliderBarriles
                if (regaderasCanvas != null)
                {
                    regaderasCanvas.gameObject.SetActive(true); // Activar el canvas TextMeshPro
                    StartCoroutine(DesactivarSmogCanvas());
                    smogParticulas.SetActive(false);
                }
            }
        }

        if (other.CompareTag("ExtintoresIncendio2"))
        {
            Destroy(other.gameObject); // Destruir el barril que el jugador tocó
            extintores2Destruidos++;

            if (extintores2Destruidos >= extintores2.Length)
            {
                // Todos los barriles han sido destruidos
                Destroy(colliderRegaderas); // Destruir el objeto colliderBarriles
                if (IncendioCanvas != null)
                {
                    IncendioCanvas.gameObject.SetActive(true); // Activar el canvas TextMeshPro
                    StartCoroutine(DesactivarincendioCanvas());
                    IncendioParticulas.SetActive(false);
                }
            }
        }

        if (barrilesDestruidos >= barriles.Length &&
           extintoresDestruidos >= extintores.Length &&
           regaderasDestruidos >= regaderas.Length &&
           extintores2Destruidos >= extintores2.Length)
        {
            // Todos los objetos han sido recolectados
            StartCoroutine(EsperarYCambiarEscena());
        }
    }
    private IEnumerator FirstCanvas()
    {
        yield return new WaitForSeconds(7f); // Esperar el tiempo especificado
        if (InicioCanvas != null)
        {
            InicioCanvas.gameObject.SetActive(false); // Desactivar el canvas TextMeshPro
        }
    }

    private IEnumerator DesactivarAguaCanvas()
    {
        yield return new WaitForSeconds(10f); // Esperar 5 segundos
        if (aguaCanvas != null)
        {
            aguaCanvas.gameObject.SetActive(false); // Desactivar el canvas TextMeshPro después de 5 segundos
        }
    }    
    
    private IEnumerator DesactivarFuegoCanvas()
    {
        yield return new WaitForSeconds(10f); // Esperar 5 segundos
        if (llantasCanvas != null)
        {
            llantasCanvas.gameObject.SetActive(false); // Desactivar el canvas TextMeshPro después de 5 segundos
        }
    }

    private IEnumerator DesactivarSmogCanvas()
    {
        yield return new WaitForSeconds(10f); // Esperar 5 segundos
        if (regaderasCanvas != null)
        {
            regaderasCanvas.gameObject.SetActive(false); // Desactivar el canvas TextMeshPro después de 5 segundos
        }
    } 
    private IEnumerator DesactivarincendioCanvas()
    {
        yield return new WaitForSeconds(10f); // Esperar 5 segundos
        if (IncendioCanvas != null)
        {
            IncendioCanvas.gameObject.SetActive(false); // Desactivar el canvas TextMeshPro después de 5 segundos
        }
    }
    
    private IEnumerator EsperarYCambiarEscena()
    {
        yield return new WaitForSeconds(15f);
         SceneManager.LoadScene("FinalScene");
    }
}
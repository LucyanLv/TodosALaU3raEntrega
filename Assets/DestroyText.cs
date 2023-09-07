using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(destroyText());   
    }

    IEnumerator destroyText()
    {
        yield return new WaitForSecondsRealtime(5f);
        this.gameObject.SetActive(false);
    }
}

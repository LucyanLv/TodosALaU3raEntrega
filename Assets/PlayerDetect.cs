using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetect : MonoBehaviour
{

    Animator spikeHeadAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("Player"))
        {
            spikeHeadAnimator.SetBool("PlayerIsThere", true);
        }
        else
        {
            spikeHeadAnimator.SetBool("PlayerIsThere", false);
        }
    }
}
